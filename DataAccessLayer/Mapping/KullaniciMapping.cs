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
   public class KullaniciMapping:EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMapping()
        {
            this.HasKey(x => x.KullanıcıID);

            this.Property(x => x.KullanıcıID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(x => x.Adı).HasMaxLength(20).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x => x.Soyadı).HasMaxLength(20).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x => x.KullanıcıMail).HasMaxLength(20).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x=> x.KullanıcıŞifre).HasMaxLength(10).HasColumnType("nvarchar").IsUnicode(true);


            this.HasMany(ıf => ıf.IletisimFormlari)
                .WithRequired(k => k.Kullanici)
                .HasForeignKey(k => k.KullaniciID);

            this.HasMany(tb => tb.TüketilenBesinler)
                .WithMany(p => p.Kullanicilar)
                .Map(tb =>
                {
                    tb.MapLeftKey("TüketilenBesinlerId"); //Ara tabloda oluşacak olan ID isimleri
                    tb.MapRightKey("KullanicilarId");
                    tb.ToTable("KullaniciTuketilenBesinler");
                });
        }
    }
}
