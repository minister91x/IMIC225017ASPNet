using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.DataObject;

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
            return 1;

        }


        public int TinhTong_ListObject(List<TinhTong_InputData> inputData)
        {

            foreach (var item in inputData)
            {

            }
            return 1;
        }
    }
}
