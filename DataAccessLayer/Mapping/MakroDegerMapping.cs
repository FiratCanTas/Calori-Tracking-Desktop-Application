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
    public class MakroDegerMapping : EntityTypeConfiguration<MakroDeger>
    {
        public MakroDegerMapping()
        {
            this.HasKey(b => b.MakroDegerID);

            this.Property(b => b.MakroDegerID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).IsRequired();
        }
    }
}
