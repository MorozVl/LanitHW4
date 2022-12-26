using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanitHW4.DB.WorkWithUsers
{
    public class Create : Read
    {
        public void CreateGame() 
        {
            ReadGames();
            DbGames games = new DbGames();

            Console.Write("Введите следущий game_id: ");
            games.Game_id = int.Parse(Console.ReadLine());

            Console.Write("Введите название команды: ");
            games.Team = Console.ReadLine();

            Console.Write("Введите город: ");
            games.City = Console.ReadLine();

            Console.Write("Введите количетво голов: ");
            games.Goals = int.Parse(Console.ReadLine());

            Console.Write("Введите время когда был сыгран матч в формате YYYY-MM-DD HH:MM: ");
            games.Game_data = DateTime.Parse(Console.ReadLine());

            using(FootboldbContext context = new FootboldbContext())
            {
                context.Games.Add(games);
                context.SaveChanges();

                DbGames games1 = context.Games.LastOrDefault();

                Console.WriteLine($"Новый матч добавлен: \n{games1}");
            }
            
        }
        public void CreatePlayer() 
        {
            ReadPlayers();
            DbPlayers player = new DbPlayers();

            Console.Write("Введите следующий player_id: ");
            player.player_id= int.Parse(Console.ReadLine());

            Console.Write("Введите фамилию игрока: ");
            player.first_name = Console.ReadLine();

            Console.Write("Введите имя игока: ");
            player.last_name = Console.ReadLine();

            Console.Write("Введите позывной игрока: ");
            player.nickname = Console.ReadLine();

            Console.Write("Введите город рождения: ");
            player.citizenship = Console.ReadLine();

            Console.Write("Введите дату рождения игрока в формате YYYY-MM-DD: ");
            player.dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите роль игрока: ");
            player.role = int.Parse(Console.ReadLine());

            using(FootboldbContext context = new FootboldbContext())
            {
                context.Players.Add(player);
                context.SaveChanges();

                DbPlayers player1 = context.Players.LastOrDefault();
                Console.WriteLine($"Игрок добавлен: \n{player1}");
                

            }

        }
    }
}
