using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanitHW4.DB
{
    [DbContext(typeof(FootboldbContext))]
    [Migration("202212231536_Addkeys")]
    public class Addkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_games",
                table: "games",
                column: "game_id"
                );


            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "players",
                column: "player_id"
                );

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lineups_G",
                table: "lineups",
                column: "game_id"
                );

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lineups_P",
                table: "lineups",
                column: "player_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Game_id",
                table:"lineups",
                column: "game_id",
                principalTable: "Games"
                );

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_id",
                table: "lineups",
                column: "player_id",
                principalTable: "players"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder) { }

    }
}
