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
    public class IletisimFormMapping : EntityTypeConfiguration<IletisimFormlari>
    {
        public IletisimFormMapping()
        {
            this.HasKey(x => x.FormID);

            this.Property(x => x.FormID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.HasRequired(x => x.Kullanici)
                .WithMany(x => x.IletisimFormlari)
                .HasForeignKey(x => x.FormID);
        }

    }
}
