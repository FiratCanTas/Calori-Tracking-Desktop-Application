using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class TuketilenBesin:ITuketilenBesin,IBaseEntity
    {
        public Ogunler BesininTüketildiğiÖğün { get; set; }
        public int BesinMakroID { get; set; }
        public DateTime TüketilenTarih { get; set; }
        public int İçilenSuMiktarı { get; set; }
        public Kullanici Kullanıcı { get; set; }
        public int KullanıcıID { get; set; }



        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status status { get; set; }
    }
}
