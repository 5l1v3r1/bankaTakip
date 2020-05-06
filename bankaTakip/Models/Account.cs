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
        [Display(Name ="Aktif Mi")]
        public bool AktifMi { get; set; }
        [Display(Name ="Varsayılan Hesap")]
        public bool VarsayılanHesapMi { get; set; }
        [Display(Name="Oluşturulma Tarihi")]
        public DateTime EklenmeTarihi { get; set; }
        [Display(Name = "Güncelleme Tarihi")]
        public DateTime GuncellemeTarihi { get; set; }

        public virtual ICollection<BranchAccount> BranchAccounts { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}