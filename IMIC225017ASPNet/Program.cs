using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.DataObject;
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

            Console.WriteLine($"số b= : {b}");
            Console.WriteLine($"số y=: {y}");
            switch (x)
            {
                case 1:
                    Console.WriteLine("x=1");
                    break;
                case 2:
                    Console.WriteLine("x=2");
                    break;

                case 3:
                    Console.WriteLine("x=3");
                    break;

                case 4:
                    Console.WriteLine("x=4");
                    break;

                case 5:
                    Console.WriteLine("x=5");
                    break;
                default:
                    break;
            }


            if (x == 10)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("fail");
            }

            var message = x == 10 ? "ok 10" :
                x == 15 ? "ok 15" :
                x == 20 ? "ok 20" :
                x == 30 ? "ok 30" : "fail";

            Console.WriteLine(message);

            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);


            for (int i = 1; i <= list.Count; i++)
            {
                //if (i % 2 == 0)
                //{
                //    continue;
                //}
                Console.WriteLine(" for - {0} là số ", i);

                //Console.WriteLine("{0} là số lẻ", i);
            }


            foreach (var item in list)
            {
                Console.WriteLine("foreach - {0} là số ", item);
            }


            var bai4_VN = new IMIC225017.DataAccess.DataAccessLayer.Bai4();

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



            var inputObject = new TinhTong_InputData();
            inputObject.SoThuNhat = 10;
            inputObject.SoThuHai = 100;
            var resultObject = bai4_VN.TinhTong_Object(inputObject);
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
