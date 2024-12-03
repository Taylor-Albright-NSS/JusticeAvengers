using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JusticeAvengers.Migrations
{
    /// <inheritdoc />
    public partial class HeroQuestManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "QuestId",
                table: "Heroes");

            migrationBuilder.AlterColumn<int>(
                name: "HeroId",
                table: "Equipment",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "HeroQuest",
                columns: table => new
                {
                    HeroesId = table.Column<int>(type: "integer", nullable: false),
                    QuestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroQuest", x => new { x.HeroesId, x.QuestId });
                    table.ForeignKey(
                        name: "FK_HeroQuest_Heroes_HeroesId",
                        column: x => x.HeroesId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroQuest_Quests_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_TypeId",
                table: "Equipment",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroQuest_QuestId",
                table: "HeroQuest",
                column: "QuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_EquipmentTypes_TypeId",
                table: "Equipment",
                column: "TypeId",
                principalTable: "EquipmentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Heroes_HeroId",
                table: "Equipment",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_EquipmentTypes_TypeId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Heroes_HeroId",
                table: "Equipment");

            migrationBuilder.DropTable(
                name: "HeroQuest");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_TypeId",
                table: "Equipment");

            migrationBuilder.AddColumn<int>(
                name: "QuestId",
                table: "Heroes",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HeroId",
                table: "Equipment",
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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 7,
                column: "QuestId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 8,
                column: "QuestId",
                value: 5);

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
                column: "QuestId");

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
                principalColumn: "Id");
        }
    }
}
