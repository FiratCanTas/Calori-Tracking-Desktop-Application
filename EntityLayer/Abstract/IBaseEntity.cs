using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
   public interface IBaseEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? DeletedDate { get; set; }



        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
        string DeletedBy { get; set; }



        Status status { get; set; }
    }
}
