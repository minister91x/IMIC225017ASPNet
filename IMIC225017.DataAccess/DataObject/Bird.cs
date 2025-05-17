using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    internal class Bird: Animal
    {
        public override string MakeSound()
        {
            return "Chirp";
        }
        public override void Eat()
        {
            Console.WriteLine("Bird ăn sâu.");
        }
        public override void Display()
        {
            Console.WriteLine("Bird is display.");
        }
    }
    {
    }
}
