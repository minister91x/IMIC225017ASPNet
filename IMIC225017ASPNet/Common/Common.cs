using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017ASPNet.Common
{
    public static class Common
    {
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
