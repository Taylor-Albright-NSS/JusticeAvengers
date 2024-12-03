using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JusticeAvengers.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Heroes_QuestId",
                table: "Heroes");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_QuestId",
                table: "Heroes",
                column: "QuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Heroes_QuestId",
                table: "Heroes");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_QuestId",
                table: "Heroes",
                column: "QuestId",
                unique: true);
        }
    }
}
