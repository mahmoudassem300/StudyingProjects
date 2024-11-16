using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Tutorial.Migrations
{
    /// <inheritdoc />
    public partial class DefaultValuesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Blogs");
        }
    }
}
