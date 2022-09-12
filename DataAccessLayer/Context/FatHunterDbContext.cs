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

        public FatHunterDbContext() : base("Server = E-KAKAR; Database = FatHunterDb; Uid=sa; Pwd=1234")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<FatHunterDbContext>());
        }

        public DbSet<Kullanici> Kullanıcılar { get; set; }
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<TuketilenBesin> TuketilenBesinler { get; set; }
        public DbSet<MakroDeger> MakroDegerler { get; set; }
        public DbSet<IletisimFormlari> IletisimFormlari { get; set; }

        //Mapping işlemlerini bununla yapabilirim
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

