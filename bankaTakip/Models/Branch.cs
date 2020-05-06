using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Branch
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Banka")]
        public int BankaNo { get; set; }
        [Display(Name = "Şube Adı")]
        public string SubeAdi { get; set; }
        [Display(Name = "Şube Kodu")]
        public int SubeKodu { get; set; }

        [ForeignKey("BankaNo")]
        public virtual Bank Bank { get; set; }
    }
}