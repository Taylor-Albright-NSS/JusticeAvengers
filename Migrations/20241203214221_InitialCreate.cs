using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JusticeAvengers.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    HeroClassId = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_HeroClasses_HeroClassId",
                        column: x => x.HeroClassId,
                        principalTable: "HeroClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    HeroId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_EquipmentTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "EquipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HeroQuest",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "integer", nullable: false),
                    QuestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroQuest", x => new { x.HeroId, x.QuestId });
                    table.ForeignKey(
                        name: "FK_HeroQuest_Heroes_HeroId",
                        column: x => x.HeroId,
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

            migrationBuilder.InsertData(
                table: "EquipmentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sword" },
                    { 2, "Bow" },
                    { 3, "Staff" },
                    { 4, "Shield" },
                    { 5, "Axe" },
                    { 6, "Accessory" },
                    { 7, "Potion" }
                });

            migrationBuilder.InsertData(
                table: "HeroClasses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Warrior" },
                    { 2, "Archer" },
                    { 3, "Wizard" },
                    { 4, "Halfling" },
                    { 5, "Shieldmaiden" },
                    { 6, "Dwarf" }
                });

            migrationBuilder.InsertData(
                table: "Quests",
                columns: new[] { "Id", "Description", "IsCompleted", "Name" },
                values: new object[,]
                {
                    { 1, "Eliminate the orc horde threatening the kingdom", false, "Defeat the Orcs" },
                    { 2, "Save the captured elf from the goblin cave", false, "Rescue the Elf" },
                    { 3, "Find the ancient amulet lost in the haunted forest", false, "Retrieve the Amulet" },
                    { 4, "Protect the castle from the siege of the dark army", true, "Defend the Castle" },
                    { 5, "Uncover the secrets of the ancient ruins", false, "Explore the Ruins" }
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Description", "HeroClassId", "Level", "Name" },
                values: new object[,]
                {
                    { 1, "A skilled ranger and warrior", 1, 20, "Aragorn" },
                    { 2, "An elven archer with unmatched precision", 2, 18, "Legolas" },
                    { 3, "A wise and powerful wizard", 3, 25, "Gandalf" },
                    { 4, "A brave halfling on a dangerous journey", 4, 10, "Frodo" },
                    { 5, "A fierce shieldmaiden of Rohan", 5, 15, "Eowyn" },
                    { 6, "A noble warrior with a strong sense of duty", 1, 17, "Boromir" },
                    { 7, "A stout and fearless dwarf warrior", 6, 16, "Gimli" },
                    { 8, "A king of the woodland elves", 2, 22, "Thranduil" },
                    { 9, "A graceful elf skilled in healing and magic", 3, 14, "Arwen" },
                    { 10, "A loyal companion with unwavering courage", 4, 12, "Samwise" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Description", "HeroId", "Name", "TypeId", "Weight" },
                values: new object[,]
                {
                    { 1, "A blade imbued with the essence of courage", 1, "Sword of Valor", 1, 12.5m },
                    { 2, "A bow crafted by the finest elven craftsmen", 2, "Elven Bow", 2, 4.3m },
                    { 3, "A staff that channels arcane power", 3, "Wizard's Staff", 3, 8.1m },
                    { 4, "A shield that radiates divine protection", 5, "Shield of Light", 4, 15.7m },
                    { 5, "A heavy axe forged in the mountain halls", 7, "Dwarven Axe", 5, 20.2m },
                    { 6, "A magical ring that grants invisibility", 4, "Ring of Stealth", 6, 0.2m },
                    { 7, "The personal weapon of the woodland king", 8, "Bow of Thranduil", 2, 3.9m },
                    { 8, "Restores health when consumed", 9, "Potion of Healing", 7, 0.5m },
                    { 9, "A ceremonial weapon with a razor-sharp edge", 10, "Golden Dagger", 1, 2.3m },
                    { 10, "Grants increased physical power", 1, "Amulet of Strength", 6, 1.1m }
                });

            migrationBuilder.InsertData(
                table: "HeroQuest",
                columns: new[] { "HeroId", "QuestId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 4, 5 },
                    { 5, 4 },
                    { 6, 3 },
                    { 7, 5 },
                    { 8, 2 },
                    { 9, 3 },
                    { 10, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_HeroId",
                table: "Equipment",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_TypeId",
                table: "Equipment",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_HeroClassId",
                table: "Heroes",
                column: "HeroClassId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroQuest_QuestId",
                table: "HeroQuest",
                column: "QuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "HeroQuest");

            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Quests");

            migrationBuilder.DropTable(
                name: "HeroClasses");
        }
    }
}
