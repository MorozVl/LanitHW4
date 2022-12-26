using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanitHW4.DB.Migrations
{
    [DbContext(typeof(FootboldbContext))]
    [Migration("202212241252_initCreate")]
    public class initCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: t => new
                {
                    Game_id = t.Column<int>(nullable: false, type: "int"),
                    Team = t.Column<string>(nullable: false),
                    City = t.Column<string>(nullable: false),
                    Goals = t.Column<int>(nullable: false),
                    Game_data = t.Column<DateTime>(nullable: false, type: "datetime2(7)"),
                },
                constraints: t =>
                {
                    t.PrimaryKey("PK_Games", x => x.Game_id);
                }
                );

            migrationBuilder.CreateTable(
                name: "Players",
                columns: t => new
                {
                    Player_id = t.Column<int>(nullable: false, type: "int"),
                    First_name = t.Column<string>(nullable: false),
                    Last_name = t.Column<string>(nullable: true),
                    Nickname = t.Column<string>(nullable: true),
                    Citizenship = t.Column<string>(nullable: true),
                    Dob = t.Column<DateTime>(nullable: false, type: "date"),
                    Role = t.Column<int>(nullable: false)
                },
                constraints: t =>
                {
                    t.PrimaryKey("PK_Players", x => x.Player_id);
                }
                );

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Players");
            migrationBuilder.DropTable("Games");
        }

    }
}
