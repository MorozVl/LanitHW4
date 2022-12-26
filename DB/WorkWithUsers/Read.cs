using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanitHW4.DB.WorkWithUsers
{
    public class Read
    {
        public void ReadGames()
        {
            using(FootboldbContext context = new FootboldbContext())
            {
                List<DbGames> games = context.Games.ToList();

                Console.WriteLine("Game_id\tTeam\tCity\tGoals\tGame_data");
                foreach (var game in games)
                {
                    Console.WriteLine($"{game.Game_id}\t{game.Team}\t{game.City}\t{game.Goals}\t{game.Game_data}");
                }
            }
        }

        public void ReadPlayers()
        {
            using (FootboldbContext context = new FootboldbContext())
            {
                List<DbPlayers> players = context.Players.ToList();

                Console.WriteLine("player_id\tfirst_name\tlast_name\tnickname\tcitizenship\tdob\t\t\trole");
                foreach (var player in players)
                {
                    Console.WriteLine($"{player.player_id}\t\t{player.first_name}\t\t{player.last_name}" +
                        $"\t\t{player.nickname}\t\t{player.citizenship}\t\t{player.dob}\t{player.role}");
                }
            }
        }
    }
}
