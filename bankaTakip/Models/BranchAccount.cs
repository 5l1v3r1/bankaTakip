using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class BranchAccount
    {
        [Key]
        public int No { get; set; }
        [Display(Name ="Şube")]
        public int SubeNo { get; set; }
        [Display(Name ="Hesap")]
        public int HesapNo { get; set; }

        [ForeignKey("SubeNo")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("HesapNo")]
        public virtual Account Account { get; set; }
    }
}