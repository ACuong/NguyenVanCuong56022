using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenVanCuong56022
{
    public class NVC056022
    {
        [Key]
        [StringLength(20)]
        [Display(Name ="ID")]
        public string NVCID { get; set; }

        [Display(Name ="Tên")]
        [StringLength(50)]
        public string NVCName { get; set; }
        
        [Display(Name ="Giới Tính")]
        public Boolean NVCGender { get; set; }
    }
}