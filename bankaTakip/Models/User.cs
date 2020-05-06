using bankaTakip.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class User
    {
        [Key]
        public int No { get; set; }
        [Display(Name ="Adı")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Adi { get; set; }
        [Display(Name = "Soyadı")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Soyadi { get; set; }
        [Display(Name = "Mail Adresi")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string MailAdresi { get; set; }
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Sifre { get; set; }
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        [Compare("Sifre",ErrorMessage ="Şifreler uyuşmamaktadır.")]
        public string SifreTekrar { get; set; }
        [Display(Name = "Rolü")]
        public Role Rol { get; set; }
        public Gender Cinsiyet { get; set; }
    }
}