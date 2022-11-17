using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje05_MVC_EfCore_CodeFirst_Tekrar.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Yas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Yas = table.Column<int>(type: "INTEGER", nullable: false),
                    BolumId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bolums",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Matematik" });

            migrationBuilder.InsertData(
                table: "Bolums",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Türkçe" });

            migrationBuilder.InsertData(
                table: "Bolums",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Fizik" });

            migrationBuilder.InsertData(
                table: "Bolums",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Kimya" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Yas" },
                values: new object[] { 1, "Mert", 23 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Yas" },
                values: new object[] { 2, "Osman", 17 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Yas" },
                values: new object[] { 3, "Mehmet", 21 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Yas" },
                values: new object[] { 4, "Kerem", 22 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BolumId", "Name", "Yas" },
                values: new object[] { 1, 4, "Selami", 45 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BolumId", "Name", "Yas" },
                values: new object[] { 2, 3, "Yasin", 54 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BolumId", "Name", "Yas" },
                values: new object[] { 3, 1, "Doğan", 28 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BolumId", "Name", "Yas" },
                values: new object[] { 4, 2, "Mahmut", 37 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BolumId", "Name", "Yas" },
                values: new object[] { 5, 1, "Aysel", 33 });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_BolumId",
                table: "Teachers",
                column: "BolumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Bolums");
        }
    }
}
