using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Tutorial.Migrations
{
    /// <inheritdoc />
    public partial class ComputerColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Authors",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                computedColumnSql: "[FirstName] + ' ' + [LastName]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Authors");
        }
    }
}
