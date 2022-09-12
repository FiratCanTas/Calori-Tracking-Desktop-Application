using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
   public class KullaniciMapping:EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMapping()
        {
            this.HasKey(x => x.KullanıcıID);

            
        }
    }
}
