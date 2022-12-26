using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanitHW4.DB.WorkWithUsers
{
    public class Delete : Read
    {
        public void DeletGame()
        {
            Console.Write("Введите game_id записи которую хотите удалить:");
            ReadGames();
            int game_id = int.Parse(Console.ReadLine());
            using (FootboldbContext context = new FootboldbContext())
            {
                DbGames games = context.Games.FirstOrDefault(g => g.Game_id == game_id);

                if (games != null)
                {
                    context.Games.Remove(games);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Такой игры не было!");
                }
            };
        }

        public void DeletPlayer()
        {
            Console.WriteLine("Введите player_id записи которую хотите удалить:");
            ReadPlayers();
            int player_id = int.Parse(Console.ReadLine());
            using (FootboldbContext context = new FootboldbContext())
            {
                DbPlayers player = context.Players.FirstOrDefault(p => p.player_id == player_id);
                if (player != null)
                {
                    context.Players.Remove(player);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Такого игрока нет!");
                }
            };
       }
    }
} 
