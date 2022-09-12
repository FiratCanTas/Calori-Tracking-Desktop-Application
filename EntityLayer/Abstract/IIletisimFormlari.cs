using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface IIletisimFormlari
    {
        int FormID { get; set; }
        string KullanıcıAdi { get; set; }
        string MailAdresi { get; set; }
        string Konu { get; set; }
        string OneriSikayet { get; set; }

         Kullanici Kullanici { get; set; }
        int KullaniciID { get; set; }
    }
}
