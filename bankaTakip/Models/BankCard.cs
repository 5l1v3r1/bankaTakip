﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class BankCard
    {
        [Key]
        public int No { get; set; }
        [Display(Name ="Banka Adı")]
        public int BankaNo { get; set; }
        [Display(Name = "Kart Adı")]
        public int CardNo { get; set; }
    }
}