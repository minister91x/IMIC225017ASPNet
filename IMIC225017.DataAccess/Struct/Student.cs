using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.Struct
{
    public struct Student
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int DienTrungBinh { get; set; }
    }
}
