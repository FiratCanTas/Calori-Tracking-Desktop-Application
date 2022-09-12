using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class MakroDeger:IMakroDeger,IBaseEntity
    {

        public int BesinMakroID { get; set; }
        public int BesinID { get; set; }
        public int KarbonhidratMiktari { get; set; }
        public int YagMiktari { get; set; }
        public int ProteinMiktari { get; set; }



        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status status { get; set; }
    }
}

