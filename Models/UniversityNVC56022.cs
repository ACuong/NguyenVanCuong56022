using System;
using System.ComponentModel.DataAnnotations;

namespace  NguyenVanCuong56022
{
    public class UniversityNVC56022
    {
        [Key]
        [StringLength(20)]
        [Required]
        [Display(Name ="ID")]
        public string UniversityId { get; set; }

        [StringLength(50)]
        [Display(Name ="Tên")]
        public string UniversityName { get; set; }
    }
}