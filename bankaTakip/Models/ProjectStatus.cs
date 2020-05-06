using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class ProjectStatus
    {
        [Key]
        public int No { get; set; }
        [Display(Name="Yapılacak")]
        public string Aciklama { get; set; }
    }
}