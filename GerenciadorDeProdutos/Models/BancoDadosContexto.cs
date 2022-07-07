using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GerenciadorDeProdutos.Model
{
    public class BancoDadosContexto : DbContext
    {
        //Mapeamento Code-First.
        public BancoDadosContexto() : base("Name=BancoDadosContexto")
        {
            Database.SetInitializer<BancoDadosContexto>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("TB_PRODUTO");
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}