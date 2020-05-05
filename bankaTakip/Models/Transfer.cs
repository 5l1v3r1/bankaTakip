using bankaTakip.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Transfer
    {
        public int No { get; set; }
        public int HesapNo { get; set; }
        public int MusteriNo { get; set; }
        public double Tutar { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string Description { get; set; }
        public PaymentMethod OdemeTipi { get; set; }
    }
}