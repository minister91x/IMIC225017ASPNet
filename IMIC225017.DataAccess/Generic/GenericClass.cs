using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.Generic
{
    public class GenericClass<T>
    {
        public T Properties { get; set; } // thuộc tính

        //public GenericClass(T properties)
        //{
        //    Properties = properties;
        //}

        // Phương thức 
        public T Display()
        {
            return Properties;
        }
    }
}
