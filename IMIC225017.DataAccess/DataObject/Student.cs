using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    public class Student // intenal và public đều được
    {
        // phạm vi truy cập của thuộc tính :
        //(internal ,private, protected, public)
        // phạm vi truy cập của class : intenal và public
        public int Id { get; set; } // thuộc tính id chỉ có thể được sử dụng bên trong class kế thưa lại nó
                                    // public string Name { get; set; }
                                    //public string Address { get; set; }

        //Hàm khởi tạo
        // tên lớp và tên hàm khởi tạo giống nhau
        // không có kiểu trả về
        // sealed ở class ngăn không cho kế thừa lại class này
        // private ở thuộc tính /phương thức: ngăn không cho truy cập từ bên ngoài
        // private ở contructor: ngăn không cho khởi tạo đối tượng từ bên ngoài
        public Student()
        {

        }
        public Student(int id, string name, string address)
        {
            Id = id;

        }


        // Phương thức
        public string GetInfo()
        {
            return $"Id: {Id}";
        }

        public void ShowInfo()
        {

        }


    }


}
