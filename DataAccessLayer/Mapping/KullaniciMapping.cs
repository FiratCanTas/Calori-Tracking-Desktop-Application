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
    public class KullaniciMapping : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMapping()
        {
            this.HasKey(x => x.KullanıcıID);

            this.Property(x => x.KullanıcıID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(x => x.Adı).HasMaxLength(20).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x => x.Soyadı).HasMaxLength(20).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x => x.KullanıcıMail).HasMaxLength(20).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x => x.KullanıcıŞifre).HasMaxLength(10).HasColumnType("nvarchar").IsUnicode(true);


            this.HasMany(k => k.IletisimFormlari)
                .WithRequired(ıf => ıf.Kullanici)
                .HasForeignKey(ıf => ıf.KullanıcıID);

            this.HasMany(k => k.TüketilenBesinler)
                .WithMany(tb => tb.Kullanicilar)
                .Map(k =>
                {
                    k.MapLeftKey("TüketilenBesinlerId"); //Ara tabloda oluşacak olan ID isimleri
                    k.MapRightKey("KullanicilarId");
                    k.ToTable("KullaniciTuketilenBesinler");
                });
        }
    }
}
