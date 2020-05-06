using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Todo
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Yapılacak")]
        public string Aciklama { get; set; }
        [Display(Name = "Tamamlandı Mı")]
        public bool TamamlandiMi { get; set; }
    }
}