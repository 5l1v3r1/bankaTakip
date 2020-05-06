using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Definition
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Tanım")]
        public string TanımAdı { get; set; }
        [Display(Name = "İçerik")]
        public string Icerik { get; set; }
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        [Display(Name = "Aktif Mi")]
        public bool AktifMi { get; set; }
    }
}