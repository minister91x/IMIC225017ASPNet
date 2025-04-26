using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.Common
{
    public static class ValidateInput
    {
        public static bool CheckValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            return true;
        }

        public static void CheckValidateInput(string input, out bool isValid)
        {
            isValid = true;
            if (string.IsNullOrEmpty(input))
            {
                isValid = false;
            }
        }

        public static bool CheckValidateInputNumber(string InputNumber)
        {

            if (string.IsNullOrEmpty(InputNumber))
            {
                return false;
            }

            var isNumber = int.TryParse(InputNumber, out int number);
            if (!isNumber)
            {
                return false;
            }


            if (number <= 0 || number > int.MaxValue)
            {
                return false;
            }

            return true;
        }
    }
}
