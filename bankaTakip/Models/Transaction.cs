using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Transaction
    {
        public int No { get; set; }
        public int HesapNo { get; set; }
        public DateTime IslemTarihi { get; set; }
        public double Tutar { get; set; }
        public string Aciklama { get; set; }
        public int KategoriNo { get; set; }
        public int OdemeTipi { get; set; }
        public string DokumanYolu { get; set; }

    }
}