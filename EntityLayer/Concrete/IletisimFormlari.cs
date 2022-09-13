using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class IletisimFormlari : IIletisimFormlari
    {
        public int FormID { get; set; }
        public string KullanıcıAdi { get; set; }
        public string MailAdresi { get; set; }
        public string Konu { get; set; }
        public string OneriSikayet { get; set; }
        public Kullanici Kullanici { get; set; }
        public int KullaniciID { get; set; }
    }
}
