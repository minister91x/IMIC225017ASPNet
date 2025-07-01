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
        public List<ProductGetList_ResponseData> ProductGetList(ProductGetListRequestData requestData, out int totalRecords)
        {
            var list = new List<ProductGetList_ResponseData>();
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

                cmd.Parameters.AddWithValue("@ProductName", requestData.ProductName);
                cmd.Parameters.AddWithValue("@ColorID", requestData.ColorID);
                cmd.Parameters.AddWithValue("@SizeID", requestData.SizeID);
                cmd.Parameters.AddWithValue("@PriceFrom", requestData.PriceFrom);
                cmd.Parameters.AddWithValue("@PriceTo", requestData.PriceTo);
                cmd.Parameters.AddWithValue("@PageIndex", requestData.PageIndex);
                cmd.Parameters.AddWithValue("@PageSize", requestData.PageSize);
                cmd.Parameters.AddWithValue("@TotalRecords", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var product = new ProductGetList_ResponseData
                    {
                        ProductID = reader.GetInt32(reader.GetOrdinal("ProductId")),
                        ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                        ColorName = reader.GetString(reader.GetOrdinal("ColorName")),
                        Price = Convert.ToInt32( reader.GetDecimal(reader.GetOrdinal("Price"))),
                        Sizename = reader.GetString(reader.GetOrdinal("Sizename")),
                        Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                        //   Image_url = reader.IsDBNull(reader.GetOrdinal("Image_url")) ? null : reader.GetString(reader.GetOrdinal("Image_url")),
                        // Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description"))
                    };
                    list.Add(product);
                }

                reader.Close();
                // Lấy tổng số bản ghi từ tham số đầu ra
                if (cmd.Parameters["@TotalRecords"].Value != DBNull.Value)
                {
                    totalRecords = Convert.ToInt32(cmd.Parameters["@TotalRecords"].Value);
                    // Xử lý tổng số bản ghi nếu cần
                }
                else
                {
                    totalRecords = 0; // Nếu không có giá trị, đặt về 0
                }

                // totalRecords = cmd.Parameters["@TotalRecords"].Value != DBNull.Value ? Convert.ToInt32(cmd.Parameters["@TotalRecords"].Value) : 0;

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
