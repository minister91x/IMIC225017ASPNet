using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    public class MayviTinh
    {
        public MayviTinh()
        {
           Console.WriteLine("May vi tinh");
        }

        public int ChieuDai { get; set; }
        public int ChieuRong { get; set; }
        public int UpRam()
        {
            return 10;
        }
    }
}
