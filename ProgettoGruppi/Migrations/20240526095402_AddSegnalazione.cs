using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgettoGruppi.Migrations.ProgettoGruppiDb
{
    /// <inheritdoc />
    public partial class AddSegnalazione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Segnalazioni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Problema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Luogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorita = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segnalazioni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Segnalazioni_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Segnalazioni_UserId",
                table: "Segnalazioni",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Segnalazioni");
        }
    }
}
