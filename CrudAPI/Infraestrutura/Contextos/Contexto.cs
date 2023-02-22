using Dominio.Entidades;
using Infraestrutura.Data.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infraestrutura.Data.Contextos
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public IDbContextTransaction Transacao { get; private set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            if (Database.GetPendingMigrations().Count() > 0)
            {
                Database.Migrate();
            }
        }

        // Configurar o banco de dados (e outras opções) a ser usado para este contexto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        // configurar ainda mais o modelo que foi descoberto por convenção nos tipos de entidade
        // expostos nas propriedades DbSet <TEntity>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteMap());
        }

        public IDbContextTransaction InitTransaction()
        {
            if (Transacao == null)
            {
                Transacao = this.Database.BeginTransaction();
            }

            return Transacao;
        }

        private void Commit()
        {
            if (Transacao != null)
            {
                Transacao.Commit();
                Transacao.Dispose();
                Transacao = null;
            }
        }

        private void RollBack()
        {
            if (Transacao != null)
            {
                Transacao.Rollback();
            }
        }

        private void Save()
        {
            try
            {
                ChangeTracker.DetectChanges();
                SaveChanges();
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        public void SendChanges()
        {
            Save();
            Commit();
        }

    }
}
