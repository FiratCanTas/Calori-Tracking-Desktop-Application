using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Besin : IBaseEntity, IBesin
    {
        public int BesinID { get; set; }
        public string BesinAdı { get; set; }
        public int BesinGramajı { get; set; }
        public int BesinAdedi { get; set; }
        public int BesinKalorisi { get; set; }



        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status status { get; set; }
    }
}

