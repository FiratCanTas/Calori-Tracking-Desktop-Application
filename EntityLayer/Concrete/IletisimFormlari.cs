using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class IletisimFormlari : IBaseEntity, IIletisimFormlari
    {
        public int FormID { get; set; }
        public string KullanıcıAdi { get; set; }
        public string MailAdresi { get; set; }
        public string Konu { get; set; }
        public string OneriSikayet { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status status { get; set; }
    }
}
