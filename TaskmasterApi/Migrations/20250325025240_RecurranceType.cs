using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskmasterApi.Migrations
{
    /// <inheritdoc />
    public partial class RecurranceType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecurranceTypeId",
                table: "Tasks",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecurranceTypeId",
                table: "Tasks");
        }
    }
}
