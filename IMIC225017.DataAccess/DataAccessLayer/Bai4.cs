using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.CustomException;
using IMIC225017.DataAccess.DataObject;
using IMIC225017.DataAccess.Struct;

namespace IMIC225017.DataAccess.DataAccessLayer
{
    public class Bai4
    {
        // chỉ xử lý logic 
        public int GiaiThua(string InputNumber)
        {
            // kiểm tra xem có phải là số hay không

            if (!IMIC225017.Common.ValidateInput.CheckValidateInputNumber(InputNumber))
            {
                return -1;
            }

            var numberInt = Convert.ToInt32(InputNumber);

            return numberInt == 1 ? 1 : numberInt * GiaiThua((numberInt - 1).ToString());

        }

        public static void abc(int x = 10)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public  void UserInput(string s)
        {
            if (s.Length > 3)
            {
                throw new DataTooLongExeption();
                // lỗi văng ra
            }
            //Other code - no exeption
        }


        public int TinhTong(int SoThuNhat, int SoThuHai)
        {
            return SoThuNhat + SoThuHai;
        }

        public long TinhTong(long SoThuNhat, long SoThuHai)
        {
            return SoThuNhat + SoThuHai;
        }

        public double TinhTong(double SoThuNhat, double SoThuHai)
        {
            return SoThuNhat + SoThuHai;
        }
        public decimal TinhTong(decimal SoThuNhat, decimal SoThuHai)
        {
            return SoThuNhat + SoThuHai;
        }

     
        public T TinhTong<T>(T SoThuNhat, T SoThuHai)
        {
            dynamic a = SoThuNhat;
            dynamic b = SoThuHai;
            return a + b;
        }



        public int TinhTong(int SoThuNhat, int SoThuHai, out int SecondValue, ref string ThirdValue)
        {
            SecondValue = 20;
            ThirdValue = "Xin chao cac bạn lớp IMIC202517";
            return 10; // 20
        }


        public int TinhTong_Object(TinhTong_InputData inputData)
        {
            try
            {
                int result = 0;
                int ketquaChia = 10 / result;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception Messege: " + ex.Message + " | StactTrace:" + ex.StackTrace);
                Console.WriteLine("Exception Source:" + ex.Source);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            return 1;

        }


        public int TinhTong_ListObject(List<TinhTong_InputData> inputData)
        {

            foreach (var item in inputData)
            {

            }
            return 1;
        }

        public int TinhTong_ArrayObject(Product product)
        {
            return 1;
        }
    }
}
