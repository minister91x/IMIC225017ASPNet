using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccess.Struct;
using OfficeOpenXml;

namespace IMIC225017.DataAccess.DataAccessLayer
{
    public class StudentManager
    {
        public List<Student> Student_ReadByExel()
        {
            var list = new List<Student>();

            // đọc file excel 
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            var fileExel = System.Configuration.ConfigurationManager.AppSettings["FileExcel_Key"] ?? "";
            var package = new ExcelPackage(new FileInfo(fileExel));


            var worksheet = package.Workbook.Worksheets[0];// lấy sheet đầu tiên để đọc

            int rows = worksheet.Dimension.Rows;// tổng số dòng 2
            int cols = worksheet.Dimension.Columns; // tổng số cột 3 

            for (int row = 3; row <= rows; row++) // row = 3 => đọc dữ liệu bắt đầu từ dòng số 3
            {
                var student = new Student();

                for (int col = 1; col <= cols; col++)
                {
                    student.HoTen = worksheet.Cells[row, 1].Text;
                    student.DienTrungBinh = int.Parse(worksheet.Cells[row, 3].Text);
                    //Console.Write(worksheet.Cells[row, col].Text + "\t");
                }

                list.Add(student);
                Console.WriteLine();

            }


            return list;
        }
    }
}
