using bankaTakip.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Transaction
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Hesap")]
        public int HesapNo { get; set; }
        [Display(Name = "İşlem Tarihi")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime IslemTarihi { get; set; }
        [Display(Name = "İşlem Tutarı")]
        public double Tutar { get; set; }
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        [Display(Name = "Kategori Adı")]
        public int KategoriNo { get; set; }
        [Display(Name = "Ödeme Türü")]
        public PaymentMethod OdemeTipi { get; set; }
        [Display(Name = "Dosya")]
        public string DokumanYolu { get; set; }

    }
}