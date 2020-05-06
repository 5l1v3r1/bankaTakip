using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Category
    {
        [Key]
        public int No { get; set; }
        [Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }
    }
}