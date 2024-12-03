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
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    HeroId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

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
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ClassId = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    QuestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
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
                table: "Heroes",
                columns: new[] { "Id", "ClassId", "Description", "Level", "Name", "QuestId" },
                values: new object[,]
                {
                    { 1, 1, "A skilled ranger and warrior", 20, "Aragorn", 0 },
                    { 2, 2, "An elven archer with unmatched precision", 18, "Legolas", 0 },
                    { 3, 3, "A wise and powerful wizard", 25, "Gandalf", 0 },
                    { 4, 4, "A brave halfling on a dangerous journey", 10, "Frodo", 0 },
                    { 5, 5, "A fierce shieldmaiden of Rohan", 15, "Eowyn", 0 },
                    { 6, 1, "A noble warrior with a strong sense of duty", 17, "Boromir", 0 },
                    { 7, 6, "A stout and fearless dwarf warrior", 16, "Gimli", 0 },
                    { 8, 2, "A king of the woodland elves", 22, "Thranduil", 0 },
                    { 9, 3, "A graceful elf skilled in healing and magic", 14, "Arwen", 0 },
                    { 10, 4, "A loyal companion with unwavering courage", 12, "Samwise", 0 }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.DropTable(
                name: "HeroClasses");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Quests");
        }
    }
}
