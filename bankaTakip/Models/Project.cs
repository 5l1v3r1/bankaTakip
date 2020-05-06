using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Project
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Proje Adı")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [MaxLength(50, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır")]
        public string Name { get; set; }
        [Display(Name = "Resim")]
        public string ImageURL { get; set; }
        [Display(Name = "Web Sitesi")]
        public string WebSiteURL { get; set; }
        [Display(Name = "Proje Yılı")]
        public string Date { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime createdDate { get; set; }
        [Display(Name="Aktif Mi?")]
        public bool isActive { get; set; }

        public virtual ICollection<ProjectCategory> ProjectCategories { get; set; }
    }
}