using Microsoft.EntityFrameworkCore;
using minimal_api.src.Domain.Entities;

namespace minimal_api.src.Infrastructure.DB
{
    public class Context : DbContext
    {
        private readonly IConfiguration _configAppSettings;
        public Context(IConfiguration configAppSettings)
        {
            _configAppSettings = configAppSettings;
        }
        public DbSet<Adm> Administradores { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura um usuario 
            modelBuilder.Entity<Adm>().HasData(
                new Adm
                {
                    Id = 1,
                    Email = "adm@teste.com",
                    Password = "123456",
                    Perfil = "Adm"
                });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Recebe a string de conexao, definida em appsettings.json
            var connectionString = _configAppSettings.GetConnectionString("ConnectionDb").ToString();
            // verifica se a string não é nula, ou se está vazia
            if(!string.IsNullOrEmpty(connectionString))
            {
                // se a stringo for valida, passa para o sql server
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
