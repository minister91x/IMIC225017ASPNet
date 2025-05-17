using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    public class Lion: Animal
    {
        public override string MakeSound()
        {
            return "Roar";
        }
        public override void Eat()
        {
            Console.WriteLine("Lion is eating meat.");
        }
       
    }
   
}
