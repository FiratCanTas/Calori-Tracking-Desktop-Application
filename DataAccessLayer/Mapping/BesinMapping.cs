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
    public class BesinMapping:EntityTypeConfiguration<Besin>
    {
        public BesinMapping()
        {
            this.HasKey(x => x.BesinID);

            this.Property(x => x.BesinID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(x => x.BesinAdı).HasMaxLength(20).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x => x.BesinAdedi).HasColumnType("int");

            this.Property(x => x.BesinGramajı).HasColumnType("double");

            this.Property(x => x.BesinKalorisi).HasColumnType("double");



            this.HasOptional(md => md.MakroDeger)
                .WithRequired(b => b.Besin).WillCascadeOnDelete(false);

            this.HasRequired(tb => tb.TuketilenBesin)
                .WithMany(b => b.Besinler)
                .HasForeignKey(b => b.TuketilenBesinID);

        }
    }
}
