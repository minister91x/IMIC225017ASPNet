using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    public class Product_Variants_Display_Parents
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        public List<Product_Variants_Children> variants_Childrens { get; set; }
    }

    public class Product_Variants_Children
    {
       
        public string ColorName { get; set; }
        public int Price { get; set; }
        public string SizeName { get; set; }
        public int Quantity { get; set; }
        public string Image_url { get; set; }
      
    }
}
