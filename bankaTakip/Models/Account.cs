using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Account
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Hesap Adı")]
        public string HesapAdi { get; set; }
        [Display(Name = "Hesap No")]
        public int HesapNo { get; set; }
        [Display(Name = "Hesap Ek No")]
        public int HesapEkNo { get; set; }
        [Display(Name = "Açılış Bakiyesi")]
        public double AcilisBakiyesi { get; set; }
        public bool AktifMi { get; set; }
        public bool VarsayılanHesapMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
    }
}