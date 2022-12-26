using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace LanitHW4.DB
{
    public class DbGames
    {
        [Key]
        public int Game_id { get; set; }
        public string Team { get; set; }
        public string City { get; set; }
        public int Goals { get; set; }
        public DateTime Game_data { get; set; }

        //public ICollection<DbPlayers> Players { get; set; }

        ////public DbGames()
        ////{
        ////    Players = new HashSet<DbPlayers>();
        ////}
    }

    public class DbGamesConfiguration : IEntityTypeConfiguration<DbGames>
    {
        public void Configure(EntityTypeBuilder<DbGames> builder)
        {
            builder
                .ToTable("Games");

            builder
                .HasKey(g => g.Game_id);

            //builder
            //    .HasKey(g => g.Players);
            //    //.WithOne(p => p.games);
        }
    }
}
