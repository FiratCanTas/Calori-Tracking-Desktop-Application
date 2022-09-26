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
    public class BesinMapping : EntityTypeConfiguration<Besin>
    {
        public BesinMapping()
        {
            this.HasKey(b => b.BesinID);

            this.Property(b => b.BesinID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(b => b.BesinAdı).IsUnicode(true);

            this.HasOptional(b => b.MakroDeger)
                .WithRequired(b => b.Besin).WillCascadeOnDelete(false);

            //this.Property(b => b.TüketilenTarih).IsOptional();
            //this.Property(b => b.BesininTuketildigiOgun).IsOptional();
        }
    }
}
