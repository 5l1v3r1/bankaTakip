using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Definition
    {
        public int No { get; set; }
        public string TanımAdı { get; set; }
        public string Icerik { get; set; }
        public string Description { get; set; }
        public bool AktifMi { get; set; }
    }
}