using DataAccessLayer.Mapping;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class FatHunterDbContext : DbContext
    {
        public FatHunterDbContext() : base("Server=DESKTOP-SH6MHS2\\MSSQLSERVER2019;Database=FatHunterDb;Trusted_Connection=True;")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<FatHunterDbContext>());
        }

        public DbSet<Kullanici> Kullanıcılar { get; set; }
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<TuketilenUrunler> TuketilenUrunlers{ get; set; }
        public DbSet<MakroDeger> MakroDegerler { get; set; }
        public DbSet<IletisimFormlari> IletisimFormlari { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BesinMapping());
            modelBuilder.Configurations.Add(new KullaniciMapping());
            modelBuilder.Configurations.Add(new MakroDegerMapping());
            modelBuilder.Configurations.Add(new IletisimFormMapping());
        }
    }
}

