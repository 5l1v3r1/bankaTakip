using bankaTakip.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Transfer
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Hesap")]
        public int HesapNo { get; set; }
        [Display(Name = "Müşteri")]
        public int MusteriNo { get; set; }
        [Display(Name = "Tutar")]
        public double Tutar { get; set; }
        [Display(Name = "İşlem Tarihi")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime IslemTarihi { get; set; }
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        [Display(Name = "Ödeme Tipi")]
        public PaymentMethod OdemeTipi { get; set; }

        [ForeignKey("MusteriNo")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("HesapNo")]
        public virtual Account Account { get; set; }
    }
}