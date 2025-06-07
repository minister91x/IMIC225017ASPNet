using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.CustomException;
using IMIC225017.DataAccess.DataAccessLayer;
using IMIC225017.DataAccess.DataObject;
using IMIC225017.DataAccess.Enum;
using IMIC225017.DataAccess.Struct;
using IMIC225017ASPNet.BTVN;


namespace IMIC225017ASPNet
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // var bai4 = new BTVN.Bai4();
            ////  bai4.GiaiThua();


            //int myValiable = 1000000;
            //Int64 b = 10000000000000000;
            //// HĐH ơi cung cấp cho 1 vùng nhớ
            //// có độ dài là 4 bytes 
            //// và gán cho biến a giá trị =10

            //var bien1 = 10;
            //var bien2 = "số mười";


            //Console.WriteLine("my_Valiable={0}", myValiable);
            //Console.WriteLine("Đến với khóa Asspnet2 Branch QUANNT");

            //myValiable = 1;

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Nhập số A: ");
            //var soA = Console.ReadLine();


            //if (!CheckValidateInput(soA))
            //{
            //    Console.WriteLine("Nhập lại số A: ");
            //    return;
            //}

            //int soThuNhat = int.Parse(Console.ReadLine()); // boxing
            //object obj = soThuNhat; // 



            //Console.WriteLine("Nhập số B: ");
            //var soB = Console.ReadLine();
            //if (!CheckValidateInput(soB))
            //{
            //    Console.WriteLine("Nhập lại số A: ");
            //    return;
            //}
            //int soThuHai = int.Parse(Console.ReadLine());

            //TinhToan(soThuNhat, soThuHai);


            int a = 10;
            int b = ++a;

            //int x = 5;
            //int y = x++;

            int x = 10;
            int y = x--;

            //Console.WriteLine($"số b= : {b}");
            //Console.WriteLine($"số y=: {y}");
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("x=1");
            //        break;
            //    case 2:
            //        Console.WriteLine("x=2");
            //        break;

            //    case 3:
            //        Console.WriteLine("x=3");
            //        break;

            //    case 4:
            //        Console.WriteLine("x=4");
            //        break;

            //    case 5:
            //        Console.WriteLine("x=5");
            //        break;
            //    default:
            //        break;
            //}


            //if (x == 10)
            //{
            //    Console.WriteLine("ok");
            //}
            //else
            //{
            //    Console.WriteLine("fail");
            //}

            //var message = x == 10 ? "ok 10" :
            //    x == 15 ? "ok 15" :
            //    x == 20 ? "ok 20" :
            //    x == 30 ? "ok 30" : "fail";

            //Console.WriteLine(message);

            //var list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);


            //for (int i = 1; i <= list.Count; i++)
            //{
            //    //if (i % 2 == 0)
            //    //{
            //    //    continue;
            //    //}
            //    Console.WriteLine(" for - {0} là số ", i);

            //    //Console.WriteLine("{0} là số lẻ", i);
            //}


            //foreach (var item in list)
            //{
            //    Console.WriteLine("foreach - {0} là số ", item);
            //}


            //var bai4_VN = new IMIC225017.DataAccess.DataAccessLayer.Bai4();

            //Console.WriteLine("mời nhập số cần tính giai thừa: ");
            //var input = Console.ReadLine();
            //var result = bai4_VN.GiaiThua(input);

            //if (result > 0)
            //{
            //    Console.WriteLine("Kết quả = {0} ", result);
            //}
            //else
            //{
            //    switch (result)
            //    {
            //        case -1:
            //            Console.WriteLine("nhập số không hợp lệ ");
            //            break;
            //        case -2:
            //            Console.WriteLine("Bạn nhập số < 0 hoặc số quá lớn ");
            //            break;
            //        case -3:
            //            Console.WriteLine("bạn nhập vào số quá lớn ");
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //int secondValueInput;
            //string thirdValueInput = string.Empty;
            //var tong = bai4_VN.TinhTong(3, 4, out secondValueInput, ref thirdValueInput);

            //Console.WriteLine("Kết quả 1 = {0} ", tong);
            //Console.WriteLine("Kết quả out = {0} ", secondValueInput);
            //Console.WriteLine("Kết quả ref = {0} ", thirdValueInput);



            //var inputObject = new TinhTong_InputData();
            //inputObject.SoThuNhat = 10;
            //inputObject.SoThuHai = 100;
            //var resultObject = bai4_VN.TinhTong_Object(inputObject);


            //try
            //{
            //    bai4_VN.UserInput("Đây là một chuỗi rất dài ...");
            //}
            //catch (DataTooLongExeption e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception otherExeption)
            //{
            //    Console.WriteLine(otherExeption.Message);
            //}

            //var product = new IMIC225017.DataAccess.Struct.Product(1, "Bánh", 1000);

            //var product2 = new IMIC225017.DataAccess.Struct.Product();
            //product2.ProductID = 2;
            //product2.ProductName = "Bánh mì";
            //product2.Price = 2000;

            //Console.WriteLine($"Product ID 1: {product.ProductID} - Tên sản phẩm: {product.ProductName} - Giá: {product.Price}");
            //Console.WriteLine($"Product ID 2: {product2.ProductID} - Tên sản phẩm: {product2.ProductName} - Giá: {product2.Price}");

            //int OrderStatus = 0;
            //if (OrderStatus == (int)OrderStatusEnum.KHOI_TAO)
            //{
            //    /// code 
            //    /// 
            //    ///
            //}
            //else if (OrderStatus == (int)OrderStatusEnum.DANG_GIAO)
            //{

            //}
            //else if (OrderStatus == (int)OrderStatusEnum.DA_GIAO)
            //{

            //}


            //int[] myArray = { 5, 1, 3 };

            //var Values_Index1 = myArray[1];
            //Console.WriteLine("Index 1 = {0}", Values_Index1);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("value = {0}", myArray[i]);
            //}

            //foreach (var item in myArray)
            //{
            //    Console.WriteLine("item = {0}", item);
            //}

            //myArray.OrderByDescending(s => s).ToList();

            //foreach (var item in myArray.OrderByDescending(s => s).ToList())
            //{
            //    Console.WriteLine("item sort = {0}", item);
            //}
            //var sum = myArray.Sum();
            //Console.WriteLine("item sum = {0}", sum);

            //var max = myArray.Max();
            //Console.WriteLine("item max = {0}", max);
            //var min = myArray.Min();
            //Console.WriteLine("item min = {0}", min);

            //myArray.


            //var studentManager = new StudentManager();
            //var list = studentManager.Student_ReadByExel();
            //if(list.Count > 0)
            //{
            //    foreach (var item in list)
            //    {
            //        Console.WriteLine($"Họ tên: {item.HoTen}");
            //        Console.WriteLine($"Điểm trung bình: {item.DienTrungBinh}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Không có dữ liệu");
            //}

            //var dateNowutc = DateTime.UtcNow; // lấy thời gian UTC ( UTC +0)
            //var dateNow = DateTime.Now; // lấy thời gian hiện tại của máy ( UTC +7)
            //Console.WriteLine($"dateNowutc: {dateNowutc}");
            //Console.WriteLine($"dateNow: {dateNow}");

            ////Cách 1: dùng các hàm Add có sẵn 
            //var conggio = dateNow.AddHours(1).AddDays(1); // cộng thêm 1 giờ
            //var trugio = dateNow.AddHours(-1); // trừ đi 1 giờ

            //Console.WriteLine($"conggio: {conggio}");
            //Console.WriteLine($"trugio: {trugio}");


            //// Cách 2: dùng TimeSpan
            //var timeSpan = new TimeSpan(2, 10, 15); // 1 giờ
            //var conggio_TimeSpan = dateNow + timeSpan; // cộng thêm 1 giờ
            //var conggio_TimeSpan2 = dateNow.Add(timeSpan); // cộng thêm 1 giờ

            //Console.WriteLine($"conggio_TimeSpan: {conggio_TimeSpan}");
            //Console.WriteLine($"conggio_TimeSpan2: {conggio_TimeSpan2}");


            //// Đo khoảng cách giữa 2 mốc thời gian

            //// Thời điểm hiện tại.
            //DateTime aDateTime = DateTime.Now;

            //// Thời điểm năm 2000
            //DateTime y2K = new DateTime(2000, 1, 1);

            //// Khoảng thời gian từ năm 2000 tới nay.
            //TimeSpan interval = aDateTime.Subtract(y2K);

            //Console.WriteLine($"conggio_TimeSpan: {interval.TotalDays}");

            //DateTime aDateTimeNow = DateTime.Now;
            //DateTime aDateTimePrevious = DateTime.Now.AddDays(-1);


            //var ketquaSoSanh = aDateTimeNow.CompareTo(aDateTimePrevious);
            //Console.WriteLine($"ketquaSoSanh: {ketquaSoSanh}");


            //DateTime aDateTime1 = new DateTime(2022, 8, 22, 19, 30, 00);
            //// Các định dạng date-time được hỗ trợ.
            //string[] formattedStrings = aDateTime1.GetDateTimeFormats();

            //foreach (string format in formattedStrings)
            //{
            //    Console.WriteLine(format);
            //}

            //Console.WriteLine($"aDateTimeNow d: {aDateTimePrevious.ToString("d/MM/yyyy HH:mm:ss")}");
            //Console.WriteLine($"aDateTimeNow dd : {aDateTimePrevious.ToString("dd/MM/yyyy HH:mm:ss")}");
            //Console.WriteLine($"aDateTimeNow ddd: {aDateTimePrevious.ToString("ddd/MM/yyyy HH:mm:ss")}");
            //Console.WriteLine($"aDateTimeNow dddd: {aDateTimePrevious.ToString("dddd/MM/yyyy HH:mm:ss")}");
            ///// 09/10 / 2023 09:00:00 dd 
            ///// 


            //var dayinMonth = DateTime.DaysInMonth(2023, 10);
            //Console.WriteLine($"dayinMonth: {dayinMonth}");

            //var createDateString = "10/05/2025666";
            ////var datefromText = DateTime.ParseExact(createDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ////Console.WriteLine($"datefromText: {datefromText.ToString("yyyy/MM/dd")}");


            //// Kiểm tra text có phải định dạng ngày tháng không 
            //DateTime dateValue;
            //if (DateTime.TryParseExact(createDateString, "dd/MM/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out dateValue))
            //{

            //    Console.WriteLine(createDateString + "đúng định dạng ngày tháng");
            //}
            //else
            //{
            //    Console.WriteLine(createDateString + "sai định dạng ngày tháng");
            //}

            //var mystring = "imic_be_net_";
            //var arr = mystring.Split('_');

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //var newstring = mystring.Substring(0, mystring.Length - 1);
            //Console.WriteLine(newstring);

            //var mystring2 = mystring.Replace("imic", "IMIC");
            //Console.WriteLine(mystring2);

            //var mystring3 = mystring2 + newstring;
            //Console.WriteLine(mystring3);


            //var bai4 = new Bai4();
            //var tong_int = bai4.TinhTong<int>(10, 20);
            //Console.WriteLine("Tong int = {0}", tong_int);

            //var tong_long = bai4.TinhTong<long>(10, 20);

            //Console.WriteLine("Tong tong_string = {0}", tong_long);

            //var tong_string = bai4.TinhTong<string>("IMIC_BE", "NETCORE");

            //Console.WriteLine("tong_string = {0}", tong_string);


            //var genericClass = new IMIC225017.DataAccess.Generic.GenericClass<string>();
            //genericClass.Properties = "IMIC BACKNET NET";
            //var result = genericClass.Display();

            //Console.WriteLine("result = {0}", result);


            //var genericClass2 = new IMIC225017.DataAccess.Generic.GenericClass<int>();

            //genericClass2.Properties = 1000;
            //var result2 = genericClass2.Display();
            //Console.WriteLine("result2 = {0}", result2);


            //var genericClass3 = new IMIC225017.DataAccess.Generic.GenericClass<Product>();
            //genericClass3.Properties = new Product(1, "IPHONE 20", 1000);
            //var result3 = genericClass3.Display();
            //Console.WriteLine("result3 = {0}", result3.ProductName);



            // var collection = new IMIC225017.DataAccess.Collection.MyCollection();

            // //collection.Dictionary();
            // //collection.ArrayList();
            // //collection.hashtable();
            // collection.HashSet();


            // var student = new IMIC225017.DataAccess.DataObject.Student();
            // student.Id = 1;

            // var student2 = new IMIC225017.DataAccess.DataObject.Student();
            // student2.Id = 2;

            //// var animal = new IMIC225017.DataAccess.DataObject.Animal();

            // var emp = new Employee();
            // emp.GoToSleep();
            // emp.GoToLunch();
            // emp.GoToSleep();
            // emp.Id = 1;
            // emp.Name = "IMIC";

            //var car = new IMIC225017.DataAccess.DataObject.Car();
            //Console.WriteLine("GetId = {0}", car.GetId());


            //var maylenovo = new IMIC225017.DataAccess.DataObject.MayLenovo();
            //maylenovo.ChieuDai = 10;
            //maylenovo.ChieuRong = 20;
            //maylenovo.UpRam();
            //maylenovo.ShowInfo();

            var productManager = new IMIC225017.DataAccess.Manager.ProductManagerment();

            //var product = new IMIC225017.DataAccess.DataObject.Product()
            //{
            //    ProductName = "DELL 123",
            //    Price = 1000,
            //    CategoryID = 1,
            //    Description="đây là mô tả"
            //};
            //var result = productManager.ProductInsert(product);

            //Console.WriteLine("ResponseMessage:{0}", result.ResponseMessage);
            //Console.WriteLine("ResponseCode: {0}", result.ResponseCode);


            var requestData = new IMIC225017.DataAccess.DataObject.ProductGetListRequestData()
            {
                CategoryID = -1,
                ProductName = "dell",
            };

            var list = productManager.ProductGetList(requestData);
            if(list.Count > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"ProductID: {item.ProductId} - Tên sản phẩm: {item.ProductName} - Giá: {item.Price} - Mô tả: {item.Description}");
                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu");
            }

        }



        public static void TinhToan(int a, int b)
        {
            Console.WriteLine($"Tích 2 số: {a * b}");
            Console.WriteLine($"Hiệu 2 số: {a - b}");
            Console.WriteLine($"Tổng 2 số: {a + b}");

            var soA = 1000;
        }


        public static bool CheckValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }


            return true;

        }

    }
}
