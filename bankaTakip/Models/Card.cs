using bankaTakip.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class Card
    {
        public int No { get; set; }
        public string KartNo { get; set; }
        public int SonKullanmaTarihi { get; set; }
        public int CVCKodu { get; set; }
        public CardPaymentSystem KartOdemeYontemi { get; set; }
        public CardType KartTipi { get; set; }
        public bool AktifMi { get; set; }
    }
}