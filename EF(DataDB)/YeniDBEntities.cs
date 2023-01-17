using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApp_MVC_Project.EF_DataDB_
{
    public class YeniDBEntities : DbContext
    {

        public YeniDBEntities()
        {
        }
        public YeniDBEntities(DbContextOptions<YeniDBEntities> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Initial Catalog=Yeni;Data Source=.\SQLEXPRESS;TrustServerCertificate=True;Persist Security Info=True;User ID=sa;Password=securiskop3;");
        }


        #region ST Ders Takip
        public DbSet<Models.OgrenciTakip.STPersonel> STPersonel { get; set; }
        public DbSet<Models.OgrenciTakip.STDers> STDers { get; set; }
        public DbSet<Models.OgrenciTakip.STOgrenci> STOgrenci { get; set; }
        public DbSet<Models.OgrenciTakip.STDersTakip> STDersTakip { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Models.OgrenciTakip.STDers>()
                .HasOne(e => e.Ogretmen)
                .WithMany(c => c.Dersler)
                .HasForeignKey(s => s.OgretmenId);
        }
    }
}

