using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sac_biblioteca_generation.Migrations
{
    /// <inheritdoc />
    public partial class BookAvailable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disponibilità",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponibilità",
                table: "Books");
        }
    }
}
