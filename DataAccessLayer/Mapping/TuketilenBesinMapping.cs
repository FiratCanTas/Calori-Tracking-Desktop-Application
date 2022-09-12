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
            this.HasKey(x => x.TuketilenBesinID);

            this.Property(x => x.TuketilenBesinID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.HasMany(x => x.Besinler)
               .WithRequired(x => x.TuketilenBesin)
               .HasForeignKey(x => x.TuketilenBesinID);

            
        }
    }
}
