using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TuketilenBesin : ITuketilenBesin
    {
        public int TuketilenBesinID { get; set; }
        public Ogunler BesininTuketildigiOgun { get; set; }

        public DateTime TüketilenTarih { get; set; }
        public int İçilenSuMiktarı { get; set; }

        public int BesinID { get; set; }
        public List<Besin> Besinler { get; set; }
        public List<Kullanici> Kullanicilar { get; set; }
    }
}
