using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.Common;
using IMIC225017.DataAccess.DataObject;
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

        public List<Product> ProductGetList(ProductGetListRequestData requestData)
        {
            var list = new List<Product>();
            try
            {
                list = GetProductList();


                if (requestData.ProductId > 0)
                {
                    list = list.Where(x => x.ProductId == requestData.ProductId).ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
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

                // kiểm tra các lỗi bảo mật như XSS , CSRF

                if (!Sercurity.CheckXSSInput(product.ProductName))
                {
                    response.ResponseCode = (int)ProductInsertStatus.ProductNotValid;
                    response.ResponseMessage = "Tên sản phẩm không hợp lệ";
                    return response;
                }

                // Check Trùng 
                var list = GetProductList();
                var isduplicate = list.Any(s => s.ProductName == product.ProductName) ? true : false;

                if (isduplicate)
                {
                    response.ResponseCode = (int)ProductInsertStatus.ProductId_Exist;
                    response.ResponseMessage = "Tên sản phẩm đã tồn tại";
                    return response;
                }


                list.Add(product);
                response.ResponseCode = (int)ProductInsertStatus.SUSCESS;
                response.ResponseMessage = "Thêm thành công";
                return response;

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
