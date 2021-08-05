using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entites;

namespace WebApplication1.Models.HocVien
{
    public class ThemHocVien
    { 
        [Required(ErrorMessage = "Tên học viên là bắt buộc")]
        [MaxLength(40)]
        public string HoVaTen { get; set; }
        [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
        public DateTime NgaySinh { get; set; }
        [Required]
        public bool GioiTinh { get; set; }
        [Required(ErrorMessage = "Email là bắt buộc")]
        [MaxLength(40)]
        public string Email { get; set; }
        [Required]
        public int MaLop { get; set; }
        public Lop Lop { get; set; }
    }
}
