using EntityLayer.Concrete;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface IKullanici
    {
        int KullanıcıID { get; set; }
        string Adı { get; set; }
        string Soyadı { get; set; }
        string KullanıcıMail { get; set; }
        string KullanıcıŞifre { get; set; }
        int Boy { get; set; }
        Cinsiyet Cinsiyet { get; set; }
        //Bir kullanıcı birden fazla besin tüketecek
        List<TuketilenBesin> TüketilenBesinler { get; set; }
        int Yas { get; set; }
        int MevcutAğırlık { get; set; }
        string AktiviteDüzeyi { get; set; }
        string DiyetHedefi { get; set; }
        int HedefAgırlıgı { get; set; }

        //İletisim form tablo listesi
        List<IletisimFormlari> IletisimFormlari { get; set; }
    }
}

