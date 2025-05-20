using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    public class ReturnData
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }

    public class ProductInsertResponseData : ReturnData
    {
    }

    public class ProductDeleteResponseData : ReturnData
    {
    }
}
