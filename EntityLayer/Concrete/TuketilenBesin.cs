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
        public Ogunler BesininTuketildigiOgun { get; set ; }
        
        public DateTime TüketilenTarih { get; set; }
        public int İçilenSuMiktarı { get; set; }
        public Kullanici Kullanıcı { get; set; }
        public int KullanıcıID { get; set; }

<<<<<<< HEAD
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status status { get; set; }
=======
        public int BesinID { get; set; }
        public List<Besin> Besinler  { get; set; }
        public List<Kullanici> Kullanicilar { get; set; }
>>>>>>> c20d59dff6e6768d0cc0d5b1eb5876fe2ce7cdcf
    }
}
