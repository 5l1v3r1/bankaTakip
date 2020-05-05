using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Branch
    {
        public int No { get; set; }
        public int BankaNo { get; set; }
        public string SubeAdi { get; set; }
        public int SubeKodu { get; set; }
    }
}