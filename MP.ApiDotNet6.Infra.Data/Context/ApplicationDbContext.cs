using Microsoft.EntityFrameworkCore;
using MP.ApiDotNet6.Domain.Entities;

namespace MP.ApiDotNet6.Infra.Data.Context {
    public class ApplicationDbContext : DbContext {

        /*
         Esse objeto é utilizado para configurar o contexto de banco de dados, 
         incluindo a string de conexão com o banco de dados e outras opções de configuração.
         */
        public DbSet<Person> People { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

        /*
         * Essa abordagem permite que as classes de configuração do modelo de dados sejam definidas em um único assembly, 
         * o que ajuda a manter o código organizado e facilita a manutenção do modelo de dados. 
         * Além disso, permite que as configurações sejam definidas separadamente do código de acesso ao banco de dados, 
         * o que torna o código mais modular e flexível. 
         */
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
