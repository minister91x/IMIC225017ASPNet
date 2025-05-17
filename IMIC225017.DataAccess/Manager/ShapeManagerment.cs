using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.Interface;

namespace IMIC225017.DataAccess.Manager
{
    public class ShapeManagerment: IShape
    {
        public double GetArea()
        {
            /// 
            return 0;
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
    
}
