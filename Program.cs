using LanitHW4.DB;
using LanitHW4.DB.WorkWithUsers;
using Microsoft.EntityFrameworkCore;

namespace LanitHW4
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (FootboldbContext context = new FootboldbContext())
            {
                context.Database.Migrate();
            }

            Menu menu = new Menu();

            menu.Menuchoice();
        }
    }
}