using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NordicDoorWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddForslagToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forslags",
                columns: table => new
                {
                    ForslagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnsattID = table.Column<int>(type: "int", nullable: false),
                    Tittel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NyttForslag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Årsak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mål = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Løsning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatoRegistrert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Frist = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<int>(type: "int", nullable: false),
                    Ansavarlig = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forslags", x => x.ForslagID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forslags");
        }
    }
}
