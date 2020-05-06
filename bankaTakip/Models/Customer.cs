using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Customer
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Adı")]
        public string Adi { get; set; }
        [Display(Name = "Soyadı")]
        public string Soyadi { get; set; }
        [Display(Name = "IBAN")]
        public string IBAN { get; set; }
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }

        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}