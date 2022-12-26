using System.ComponentModel.DataAnnotations;

namespace LanitHW4.DB
{
    public class DbPlayers
    {
        [Key]
        public int player_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string nickname { get; set; }
        public string citizenship { get; set; } 
        public DateTime dob { get; set; }
        public int role { get; set; }
        
        //public DbGames? games { get; set; }

    }

}
