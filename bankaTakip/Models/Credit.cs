using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Credit
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Çekilen Tutar")]
        public double CekilenTutar { get; set; }
        [Display(Name = "Kaç Taksit")]
        public int YapilanTaksit { get; set; }
        [Display(Name ="Kredi Çekme Tarihi")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime CekilmeTarihi { get; set; }

        public virtual ICollection<BankCredit> BankCredits { get; set; }
    }
}