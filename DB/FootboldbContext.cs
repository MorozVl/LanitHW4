using Microsoft.EntityFrameworkCore;

namespace LanitHW4.DB
{
    public class FootboldbContext : DbContext
    {

        public DbSet<DbGames> Games{ get; set; }
        public DbSet<DbPlayers> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=newfootboldb;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}
