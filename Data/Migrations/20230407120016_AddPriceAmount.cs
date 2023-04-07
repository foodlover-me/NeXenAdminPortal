using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeXenAdminPortal.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceAmount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Prices",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Prices");
        }
    }
}
