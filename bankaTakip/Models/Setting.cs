using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Setting
    {
        public int No { get; set; }
        public string MailAdresi { get; set; }
        public string Telefon { get; set; }
        public string LogoYolu { get; set; }
        public string FaviconYolu { get; set; }
    }
}