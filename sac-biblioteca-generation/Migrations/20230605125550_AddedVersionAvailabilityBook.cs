using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sac_biblioteca_generation.Migrations
{
    /// <inheritdoc />
    public partial class AddedVersionAvailabilityBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VersioneCartaceaDisponibile",
                table: "Books",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VersioneCartaceaDisponibile",
                table: "Books");
        }
    }
}
