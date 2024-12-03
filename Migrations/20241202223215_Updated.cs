using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JusticeAvengers.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Quests_QuestId",
                table: "Heroes");

            migrationBuilder.AlterColumn<int>(
                name: "QuestId",
                table: "Heroes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Quests_QuestId",
                table: "Heroes",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Quests_QuestId",
                table: "Heroes");

            migrationBuilder.AlterColumn<int>(
                name: "QuestId",
                table: "Heroes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Quests_QuestId",
                table: "Heroes",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
