using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.Interface;

namespace IMIC225017.DataAccess.DataObject
{
    public class MayLenovo : MayviTinh, IShape
    {
        public MayLenovo()
        {
            Console.WriteLine("May Lenovo");
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        // Lơp con kế thừa lớp cha và mặc được sử dụng các thuộc tính và phương thức của lớp cha ở dạng public hoăc protected
        // Nếu là protected thì chỉ có lớp con và lớp cha được sử dụng
        // Nếu là public thì lớp con và lớp cha và các lớp khác đều được sử dụng
        public void ShowInfo()
        {
            Console.WriteLine("May Lenovo :Chieu Dai ={0} Chieu rong: {1}", ChieuDai, ChieuRong);
        }
    }
}
