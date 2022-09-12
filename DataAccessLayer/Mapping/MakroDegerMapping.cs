using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
   public class MakroDegerMapping:EntityTypeConfiguration<MakroDeger>
    {
        public MakroDegerMapping()
        {
            this.HasKey(x => x.BesinMakroID);

            this.Property(x => x.BesinMakroID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

           

            this.Property(x => x.YagMiktari).HasColumnType("int");

            this.Property(x => x.ProteinMiktari).HasColumnType("int");

            this.Property(x => x.KarbonhidratMiktari).HasColumnType("double");

            
        }
   
    }
}
