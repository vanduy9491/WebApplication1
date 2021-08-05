using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entites
{
    public class HocVien
    {
        [Key]
        public int MaHV { get; set; }
        [Required]
        [MaxLength(40)]
        public string HoVaTen { get; set; }
        [Required]
        public DateTime NgaySinh { get; set; }
        [Required]
        public bool GioiTinh { get; set; }
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }
        [Required]
        public int MaLop { get; set; }
        public Lop Lop { get; set; }
    }
}
