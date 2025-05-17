using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    public partial class Employee
    {
        public int Id { get; set; }
        public void DoWork() { }
    }


    public partial class Employee
    {
        public string Name { get; set; }
        public void GoToLunch()
        {
            Console.WriteLine("Employee is going to lunch." + Id);
        }
    }

    public partial class Employee
    {
        public void GoToSleep() { }
    }
}
