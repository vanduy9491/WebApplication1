using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entites
{
    public class Lop
    {
        [Key]
        public int MaLop { get; set; }
        [Required]
        [MaxLength(300)]
        public string TenLop { get; set; }
        public ICollection<HocVien> HocViens { get; set; }
    }
}
