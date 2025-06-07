using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.Common;
using IMIC225017.DataAccess.DataObject;
using IMIC225017.DataAccess.DbHelper;
using IMIC225017.DataAccess.Enum;
using IMIC225017.DataAccess.Interface;

namespace IMIC225017.DataAccess.Manager
{
    public class ProductManagerment : IProduct
    {
        public ProductDeleteResponseData ProductDelete(List<int> ProductIDs)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Lấy danh sách sản phẩm theo yêu cầu
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public List<Product> ProductGetList(ProductGetListRequestData requestData)
        {
            var list = new List<Product>();
            try
            {
                //int a = 10; // Ví dụ về biến không sử dụng, có thể xóa nếu không cần thiết
                //list = GetProductList();


                //if (requestData.ProductId > 0)
                //{
                //    list = list.Where(x => x.ProductId == requestData.ProductId).ToList();
                //}

                var connection = new SqlDBConnection();
                var cmd = new SqlCommand("SP_Product_GetList ", connection.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // THÊM GIÁ TRỊ CHO CÁC THAM SỐ 
                cmd.Parameters.AddWithValue("@CategoryID", requestData.CategoryID);
                cmd.Parameters.AddWithValue("@ProductName", requestData.ProductName);
              
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var product = new Product
                    {
                        ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                        CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                        ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                        Price = reader.GetInt32(reader.GetOrdinal("Price")),
                        Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description"))
                    };
                    list.Add(product);
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return list;
        }

        public ProductInsertResponseData ProductInsert(Product product)
        {
            var response = new ProductInsertResponseData();
            try
            {
                // Kiểm tra đầu vào 
                if (product == null
                    || string.IsNullOrEmpty(product.ProductName)
                    || product.Price <= 0
                    || product.ProductName.Length > 250)
                {
                    response.ResponseCode = (int)ProductInsertStatus.ProductNotValid;
                    response.ResponseMessage = "Thêm không thành công";
                    return response;
                }

                //if (!ValidateInput.IsValidEmail(product.ProductName))
                //{
                //    response.ResponseCode = (int)ProductInsertStatus.ProductName_NotValid;
                //    response.ResponseMessage = "Tên sản phẩm không hợp lệ";
                //    return response;
                //}

                // kiểm tra các lỗi bảo mật như XSS , CSRF

                if (!Sercurity.CheckXSSInput(product.ProductName))
                {
                    response.ResponseCode = (int)ProductInsertStatus.ProductNotValid;
                    response.ResponseMessage = "Tên sản phẩm không hợp lệ";
                    return response;
                }

                // Check Trùng 
                //var list = GetProductList();
                //var isduplicate = list.Any(s => s.ProductName == product.ProductName) ? true : false;

                //if (isduplicate)
                //{
                //    response.ResponseCode = (int)ProductInsertStatus.ProductId_Exist;
                //    response.ResponseMessage = "Tên sản phẩm đã tồn tại";
                //    return response;
                //}


                //list.Add(product);
                //Chuyển sang gọi database để thêm sản phẩm
                var connection = new SqlDBConnection();
                var cmd = new SqlCommand("SP_ProductInsert ", connection.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // THÊM GIÁ TRỊ CHO CÁC THAM SỐ 
                cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.Add("@ResponseCode", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;


                cmd.ExecuteNonQuery();

                // Lấy giá trị trả về từ ResponseCode
                var responseCode = cmd.Parameters["@ResponseCode"].Value != (Object)DBNull.Value ? Convert.ToInt32(cmd.Parameters["@ResponseCode"].Value) : -99;

                if (responseCode > 0)
                {
                    response.ResponseCode = responseCode;
                    response.ResponseMessage = "Thêm thành công";
                    return response;
                }
                else
                {
                    switch (responseCode)
                    {
                        case -1:
                            response.ResponseCode = responseCode;
                            response.ResponseMessage = "Tên sản phẩm đã tồn tại";
                            return response;
                        case -2:
                            response.ResponseCode = responseCode;
                            response.ResponseMessage = "Danh mục sản phẩm không tồn tại";
                            return response;
                        default:
                            response.ResponseCode = -99;
                            response.ResponseMessage = "Hệ thống đang bận. Vui lòng quay lại sau";
                            return response;
                    }
                }
               

            }
            catch (Exception ex)
            {
                response.ResponseCode = (int)ProductInsertStatus.EXCEPTION;
                response.ResponseMessage = "Thêm thất bại ex:" + ex.Message + " |StackTrace" + ex.StackTrace;
                return response;
            }

        }

        private List<Product> GetProductList()
        {

            var list = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Product
                {
                    ProductId = i,
                    ProductName = "ProductName" + i,
                    Price = 1000 + i
                });
            }
            return list;
        }
    }
}
