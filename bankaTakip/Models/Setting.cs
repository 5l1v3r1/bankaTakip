using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Setting
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Mail Adresi")]
        public string MailAdresi { get; set; }
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }
        [Display(Name = "Logo")]
        public string LogoYolu { get; set; }
        [Display(Name = "Favicon")]
        public string FaviconYolu { get; set; }
    }
}