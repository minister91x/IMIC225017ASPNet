using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.Enum;

namespace IMIC225017.DataAccess.Struct
{
    public struct ProductStruct
    {
        // Thuộc tính : là đặc điểm của đối tượng ( chiều dài , cao , màu sắc ,cân nặng...)
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int Price { get; set; }

        public Category Category { get; set; }

        // hàm khởi tạo 
        // tên hàm trùng tên của Struct
        // không có kiểu trả về
        // hàm khởi tạo có tham số và các tham số phải khởi tạo đầy đủ các thuộc tính
        public ProductStruct(int productID, string productName, int price)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
        }


        /// <summary>
        ///  Phuơng thức : là hành động của đối tượng ( đi , chạy , nhảy , bơi ...)
        /// </summary>
        /// <returns></returns>
        public string PriceToString()
        {
            return Price.ToString();
        }

        public void ShowProducts(ProductItemTypes type)
        {
            switch (type)
            {
                case ProductItemTypes.LAPTOP:
                    Console.WriteLine("Laptop");
                    break;
                case ProductItemTypes.DESKTOP:
                    Console.WriteLine("Desktop");
                    break;
                case ProductItemTypes.MOBILE:
                    Console.WriteLine("Mobile");
                    break;
                case ProductItemTypes.NETWORK:
                    Console.WriteLine("Network");
                    break;
                default:
                    Console.WriteLine("Unknown type");
                    break;
            }
        }
    }

}
