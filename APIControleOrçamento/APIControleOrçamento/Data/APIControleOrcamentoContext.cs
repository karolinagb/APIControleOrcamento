using APIControleOrçamento.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIControleOrçamento.Data
{
    public class APIControleOrcamentoContext : IdentityDbContext<IdentityUser>
    {
        public APIControleOrcamentoContext(DbContextOptions<APIControleOrcamentoContext> options) : base(options)
        {

        }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Receita>(x => 
            {
                x.HasKey(x => x.Id);
                x.Property(x => x.Descricao).HasColumnType("VARCHAR(800)").IsRequired();
                x.Property(p => p.Valor).HasColumnType("DECIMAL(18,2)").IsRequired();
                x.Property(p => p.Data).HasColumnType("DATETIME").IsRequired();
            });

            modelBuilder.Entity<Despesa>(x =>
            {
                x.HasKey(x => x.Id);
                x.Property(x => x.Descricao).HasColumnType("VARCHAR(800)").IsRequired();
                x.Property(p => p.Valor).HasColumnType("DECIMAL(18,2)").IsRequired();
                x.Property(p => p.Data).HasColumnType("DATETIME").IsRequired();
            });
        }
    }
}
