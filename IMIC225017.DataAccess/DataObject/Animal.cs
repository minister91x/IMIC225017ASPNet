using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    public abstract class Animal
    {
        public abstract string MakeSound(); // abstract method
        public abstract void Eat(); // abstract method

        public virtual void Display() // virtual method
        {
            Console.WriteLine("Animal is display.");
        }
    }
}
