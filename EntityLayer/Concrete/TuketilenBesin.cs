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
        public ICollection<Besin> Besinler { get; set; }
        public List<Kullanici> Kullanicilar { get; set; }
        public int BesinId { get; set; }
    }
}
