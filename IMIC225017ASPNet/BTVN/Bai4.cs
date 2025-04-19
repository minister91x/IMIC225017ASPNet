using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017ASPNet.BTVN
{
    internal class Bai4
    {
        public void GiaiThua()
        {
            // code xử lý
            if(!IMIC225017ASPNet.Common.Common.CheckValidateInput("Nhập số nguyên dương n: "))
            {
                Console.WriteLine("Nhập lại số nguyên dương n: ");
                return;
            }
        }
    }
}
