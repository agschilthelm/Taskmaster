using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskmasterApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRecurrance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Household_HouseholdId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Household",
                table: "Household");

            migrationBuilder.RenameTable(
                name: "Household",
                newName: "Households");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CateogryId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Interval",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecurranceQuantity",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Recurring",
                table: "Tasks",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Households",
                table: "Households",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HouseholdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Members_Households_HouseholdId",
                        column: x => x.HouseholdId,
                        principalTable: "Households",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaskHistories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompletionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskHistories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaskHistories_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CategoryID",
                table: "Tasks",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_MemberId",
                table: "Tasks",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_HouseholdId",
                table: "Members",
                column: "HouseholdId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHistories_MemberId",
                table: "TaskHistories",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Categories_CategoryID",
                table: "Tasks",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Households_HouseholdId",
                table: "Tasks",
                column: "HouseholdId",
                principalTable: "Households",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Members_MemberId",
                table: "Tasks",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Categories_CategoryID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Households_HouseholdId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Members_MemberId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TaskHistories");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CategoryID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_MemberId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Households",
                table: "Households");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CateogryId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Interval",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "RecurranceQuantity",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Recurring",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Households",
                newName: "Household");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Household",
                table: "Household",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Household_HouseholdId",
                table: "Tasks",
                column: "HouseholdId",
                principalTable: "Household",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
