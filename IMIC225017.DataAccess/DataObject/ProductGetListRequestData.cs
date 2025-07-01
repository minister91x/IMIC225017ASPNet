using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace IMIC225017.DataAccess.DataObject
{
    public class ProductGetListRequestData
    {

        public string ProductName { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }
        public int PriceFrom { get; set; }
        public int PriceTo { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

    }
}
