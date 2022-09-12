using EntityLayer.Concrete;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface ITuketilenBesin
    {
        Ogunler BesininTuketildigiOgun { get; set; }
        int TuketilenBesinID { get; set; }
        DateTime TüketilenTarih { get; set; }
        int İçilenSuMiktarı { get; set; }

        //Kullanıcı tablo baglantı
        
        List<Kullanici> Kullanicilar { get; set; }
        //Besin tablo baglantı
        int BesinID { get; set; }
         List<Besin> Besinler { get; set; }
    }
}
