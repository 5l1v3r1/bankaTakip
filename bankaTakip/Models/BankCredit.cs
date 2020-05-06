using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class BankCredit
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Banka")]
        public int BankaNo { get; set; }
        [Display(Name = "Kredi")]
        public int CreditNo { get; set; }

        [ForeignKey("BankaNo")]
        public virtual Bank Bank { get; set; }

        [ForeignKey("CreditNo")]
        public virtual Credit Credit { get; set; }
    }
}