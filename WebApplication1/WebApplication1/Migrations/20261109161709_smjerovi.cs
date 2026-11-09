using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class smjerovi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SmjerId",
                table: "Studenti",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Smjer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smjer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Smjer",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Softverski inzenjering" },
                    { 2, "Razvoj softvera" }
                });

            migrationBuilder.UpdateData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 1,
                column: "SmjerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Studenti",
                keyColumn: "Id",
                keyValue: 2,
                column: "SmjerId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_SmjerId",
                table: "Studenti",
                column: "SmjerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_Smjer_SmjerId",
                table: "Studenti",
                column: "SmjerId",
                principalTable: "Smjer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_Smjer_SmjerId",
                table: "Studenti");

            migrationBuilder.DropTable(
                name: "Smjer");

            migrationBuilder.DropIndex(
                name: "IX_Studenti_SmjerId",
                table: "Studenti");

            migrationBuilder.DropColumn(
                name: "SmjerId",
                table: "Studenti");
        }
    }
}
