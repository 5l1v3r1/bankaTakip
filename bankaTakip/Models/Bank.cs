using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Bank
    {
        [Key]
        public int No { get; set; }
        [Display(Name ="Banka Adı")]
        public string BankaAdi { get; set; }
    }
}