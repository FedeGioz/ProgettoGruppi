using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgettoGruppi.Migrations
{
    /// <inheritdoc />
    public partial class AddTechnicianFlagToAspNetUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isTechnician",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
