using LanitHW4.DB.WorkWithUsers;

namespace LanitHW4
{
    public class Menu
    {
        public void Menuchoice()
        {
            Create create = new Create();
            Delete delete = new Delete();
            Read read = new Read();
            Update update = new Update();

            Console.WriteLine("Сделайте свой выбор введя пункт меню.");
            Console.WriteLine("1. Посмотреть матчи. " +
                            "\n2. Посмотреть игроков. " +
                            "\n3. Внести матч." +
                            "\n4. Внести игрока." +
                            "\n5. Обвновить голы в матче. " +
                            "\n6. Обвновить роль игрока. " +
                            "\n7. Удалить матч. " +
                            "\n8. Удалить игрока. \n");

            int menu_id = int.Parse(Console.ReadLine());

            switch (menu_id)
            {
                case 1: read.ReadGames(); 
                    break;

                case 2: read.ReadPlayers(); 
                    break;

                case 3: create.CreateGame();
                    break;

                case 4: create.CreatePlayer(); 
                    break;

                case 5: update.UpdateGame(); 
                    break;

                case 6: update.UpdatePlayer();
                    break;

                case 7: delete.DeletGame();
                    break;

                case 8: delete.DeletPlayer();
                    break;

                default: Console.WriteLine("Введено неверное значение!");
                    break;
            }

        }
    }
}
