using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccessNetCore.DataObject
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage ="Tên sản phẩm là thông tin bắt buộc")]
        [StringLength(2, ErrorMessage ="Tên sản phẩm không được quá 100 ký tự")]
       
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public int? ProductStatus { get; set; }
        public int CatorgoryId { get; set; }
        public int? IsHot { get; set; }
        public int? IsHomePage { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
