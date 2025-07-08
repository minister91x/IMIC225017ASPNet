using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccessNetCore.DataObject
{
    public class ProductGetList_ResponseData
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ColorName { get; set; }
        public int Price { get; set; }
        public string Sizename { get; set; }
        public int Quantity { get; set; }
        public string Image_url { get; set; }
        public string Description { get; set; }
    }
}
