using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Customer
    {
        public int No { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string IBAN { get; set; }
        public string Telefon { get; set; }
    }
}