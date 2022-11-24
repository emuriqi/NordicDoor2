using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NordicDoorWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddAnsattToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ansatte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fornavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etternavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rolle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ansatte", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ansatte");
        }
    }
}
