using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanitHW4.DB.WorkWithUsers
{
    public class Update : Read
    {
        public void UpdateGame()
        {
            Console.WriteLine("Выберите game_id записи, которую хотите обновить: ");
            ReadGames();
            
            using (FootboldbContext context = new FootboldbContext()) 
            {
                int game_id = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Введите новое количество голов: ");
                int goal_count = int.Parse(Console.ReadLine());
                
                DbGames games = context.Games.FirstOrDefault(g => g.Game_id == game_id);

                if (games != null)
                {
                    games.Goals = goal_count;
                    context.SaveChanges();
                }
            };
        }

        public void UpdatePlayer() 
        {
            Console.WriteLine("Выберите player_id записи, которую хотите обновить: ");
            ReadPlayers();

            using (FootboldbContext context = new FootboldbContext())
            {
                int player_id = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите новое количество голов: ");
                int role_new = int.Parse(Console.ReadLine());

                DbPlayers players = context.Players.FirstOrDefault(p => p.player_id == player_id);

                if (players != null)
                {
                    players.role = role_new;
                    context.SaveChanges();
                }
            };
        }
    }
}
