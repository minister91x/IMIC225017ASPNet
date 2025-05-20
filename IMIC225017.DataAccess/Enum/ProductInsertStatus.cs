using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.Enum
{
    public enum ProductInsertStatus
    {
        ProductNotValid = -5,
        ProductName_NotValid = -1,
        Price_NotValid = -2,
        ProductId_NotValid = -3,
        ProductId_Exist = -4,
        SUSCESS = 1,
        ERROR = 0,
        EXCEPTION = -99,
    }
}
