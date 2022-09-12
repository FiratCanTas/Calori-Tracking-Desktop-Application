using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanici :IKullanici,IBaseEntity
    {
        public int KullanıcıID { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string KullanıcıMail { get; set; }
        public string KullanıcıŞifre { get; set; }
        public int Boy { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public List<TuketilenBesin> TüketilenBesinler { get; set; }
        public int Yas { get; set; }
        public int MevcutAğırlık { get; set; }
        public string AktiviteDüzeyi { get; set; }
        public string DiyetHedefi { get; set; }
        public int HedefAgırlıgı { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status status { get; set; }
    }
}
