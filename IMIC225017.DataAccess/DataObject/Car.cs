using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DataObject
{
    public class Car
    {

        // Che giấu đi thông tin quan trọng mà không muốn cho bên ngoài biết 
        // giúp đảm bao tính an toàn cho dữ liệu
        // Giúp ẩn đi những thông tin không cần thiết về đối tượng.
        // Cho phép bạn thay đổi cấu trúc bên trong lớp mà không ảnh hưởng tới lớp khác
        private int Id_First { get; set; } = 500;
        private int Id_Send { get; set; } = 500;
        public int GetId()
        {
            return Id_First + Id_Send;
        }
    }
}
