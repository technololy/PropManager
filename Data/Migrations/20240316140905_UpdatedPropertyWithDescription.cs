using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPropertyWithDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Properties",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Properties",
                newName: "ImageUrl");
        }
    }
}
