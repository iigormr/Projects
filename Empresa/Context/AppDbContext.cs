using Microsoft.EntityFrameworkCore;
using CNPJ.Models.Empresa;
using Empresa.Models.Empresa;
using Projects.ViewModels;
using System.Configuration;

namespace Empresa.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Empresa.Empresa>().ToTable("EMP_PRINCIPAL").HasKey(x => x.id);
            modelBuilder.Entity<AtividadePrincipal>().ToTable("EMP_ATVPRINCIPAL").HasKey(x => x.id);
            modelBuilder.Entity<AtividadesSecundarias>().ToTable("EMP_ATVSECUNDARIAS").HasKey(x => x.id);
            modelBuilder.Entity<Billings>().ToTable("EMP_BILLINGS").HasKey(x => x.id);
            modelBuilder.Entity<Extra>().ToTable("EMP_EXTRA").HasKey(x => x.id);
            modelBuilder.Entity<Socio>().ToTable("EMP_SOCIO").HasKey(x => x.id);

            modelBuilder.Entity<Models.Empresa.Empresa>()
                .HasOne(em => em.extra)
                .WithOne(ex => ex.Empresa)
                .HasForeignKey<Models.Empresa.Empresa>(em => em.extraid);

            modelBuilder.Entity<Models.Empresa.Empresa>()
                .HasOne(em => em.billings)
                .WithOne(bi => bi.Empresa)
                .HasForeignKey<Models.Empresa.Empresa>(em => em.billingid);

            modelBuilder.Entity<AtividadePrincipal>()
                .HasOne(atvp => atvp.Empresa)
                .WithMany(em => em.atividade_principal)
                .HasForeignKey(em => em.empresaId);

            modelBuilder.Entity<AtividadesSecundarias>()
                .HasOne(atvs => atvs.Empresa)
                .WithMany(em => em.atividades_secundarias)
                .HasForeignKey(em => em.empresaId);

            modelBuilder.Entity<Socio>()
                .HasOne(sc => sc.Empresa)
                .WithMany(em => em.qsa)
                .HasForeignKey(em => em.empresaId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AtividadePrincipal> EMP_ATVPRINCIPAL { get; set; }
        public DbSet<AtividadesSecundarias> EMP_ATVSECUNDARIAS { get; set; }
        public DbSet<Billings> EMP_BILLINGS { get; set; }
        public DbSet<Extra> EMP_EXTRA { get; set; }
        public DbSet<Socio> EMP_SOCIO { get; set; }
        public DbSet<Models.Empresa.Empresa> EMP_PRINCIPAL { get; set; }
    }
}