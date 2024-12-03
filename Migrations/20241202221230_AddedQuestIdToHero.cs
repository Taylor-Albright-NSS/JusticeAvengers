using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JusticeAvengers.Migrations
{
    /// <inheritdoc />
    public partial class AddedQuestIdToHero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2,
                column: "QuestId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 3,
                column: "QuestId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 7,
                column: "QuestId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 8,
                column: "QuestId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 9,
                column: "QuestId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 10,
                column: "QuestId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_QuestId",
                table: "Heroes",
                column: "QuestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_HeroId",
                table: "Equipment",
                column: "HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Heroes_HeroId",
                table: "Equipment",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Quests_QuestId",
                table: "Heroes",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Heroes_HeroId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Quests_QuestId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_QuestId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_HeroId",
                table: "Equipment");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 3,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 7,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 8,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 9,
                column: "QuestId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 10,
                column: "QuestId",
                value: 0);
        }
    }
}
