using Microsoft.EntityFrameworkCore;
using CDX.Totem.Domain.Models;
using System.Threading.Tasks;
using CDX.Totem.Core.Infraestrutura.Interfaces;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CDX.Totem.Domain.Infraestrutura.Conexao
{
    public class Contexto : DbContext
    {
        public DbSet<LogEvento> LogEvento { get; set; }
        public DbSet<TotemConfig> TotemConfig { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        #region Filtros e Configurações
        private void ConfigurarSistema(ModelBuilder builder)
        {
            #region NotaFiscal
            //builder.Entity<NotaFiscal>()
            //    .HasQueryFilter(p => p.Situacao != SituacaoEnum.Excluido);
            #endregion
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            ConfigurarSistema(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
    public class Uow : IUow
    {
        private readonly Contexto _context;

        public Uow(Contexto context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Rollback()
        {
            // Do nothing :)
        }
    }
}