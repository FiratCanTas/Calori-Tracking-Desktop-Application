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

            this.Property(x => x.Boy).HasColumnType("float");

            this.Property(x => x.Yas).HasColumnType("int");

            this.Property(x => x.MevcutAğırlık).HasColumnType("float");

            this.Property(x => x.KullanıcıMail).HasMaxLength(20).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x=> x.KullanıcıŞifre).HasMaxLength(10).HasColumnType("nvarchar").IsUnicode(true);

            this.Property(x=> x.HedefAgırlıgı).HasColumnType("float");

            this.Property(x => x.status).HasColumnType("int");


            this.HasMany(x => x.IletisimFormlari)
                .WithRequired(x => x.Kullanici)
                .HasForeignKey(x => x.KullaniciID);

            this.HasMany(x => x.TüketilenBesinler)
                .WithMany(p => p.Kullanicilar)
                .Map(x =>
                {
                    x.MapLeftKey("TüketilenBesinlerId"); //Ara tabloda oluşacak olan ID isimleri
                    x.MapRightKey("KullanicilarId");
                    x.ToTable("KullaniciTuketilenBesinler");

                });





        }
    }
}
