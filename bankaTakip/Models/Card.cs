using bankaTakip.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Card
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Kart No")]
        [StringLength(19,ErrorMessage ="{0} alanı {1} hane olarak yazılmalıdır.")]
        public string KartNo { get; set; }
        [Display(Name = "Son Kullanma Tarihi")]
        public int SonKullanmaTarihi { get; set; }
        [Display(Name = "CVC")]
        public int CVCKodu { get; set; }
        [Display(Name = "Kart Ödeme Sistemi")]
        public CardPaymentSystem KartOdemeYontemi { get; set; }
        [Display(Name = "Kart Türü")]
        public CardType KartTipi { get; set; }
        [Display(Name = "Kart Aktif Mi?")]
        public bool AktifMi { get; set; }
        [Display(Name ="Hesap Kesim Günü")]
        public Int16 HesapKesimGunu { get; set; }
    }
}