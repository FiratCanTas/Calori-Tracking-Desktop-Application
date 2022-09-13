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
    public class TuketilenBesinMapping:EntityTypeConfiguration<TuketilenBesin>
    {
        public TuketilenBesinMapping()
        {
            this.HasKey(b => b.TuketilenBesinID);

            this.Property(b => b.TuketilenBesinID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.HasMany(b => b.Besinler)
               .WithRequired(tb => tb.TuketilenBesin)
               .HasForeignKey(tb => tb.TuketilenBesinID);

            
        }
    }
}
