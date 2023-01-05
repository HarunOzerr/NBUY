using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OzelDersler.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirthYear = table.Column<int>(type: "INTEGER", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Gender = table.Column<char>(type: "TEXT", nullable: false),
                    Experience = table.Column<int>(type: "INTEGER", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "TEXT", nullable: false),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false),
                    UniversityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTeachers",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTeachers", x => new { x.StudentId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Matematik", "matematik" },
                    { 2, "Fizik", "fizik" },
                    { 3, "Kimya", "kimya" },
                    { 4, "Biyoloji", "biyoloji" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "About", "DateOfRegistration", "FirstName", "LastName", "Url" },
                values: new object[,]
                {
                    { 1, "Matematik dersinde kendimi geliştirmek istiyorum.", new DateTime(2023, 1, 5, 9, 53, 21, 504, DateTimeKind.Local).AddTicks(2477), "Harun", "Özer", "harun-ozer" },
                    { 2, "Fizik dersinde kendimi geliştirmek istiyorum.", new DateTime(2023, 1, 5, 9, 53, 21, 504, DateTimeKind.Local).AddTicks(2480), "Selami", "Sadak", "selami-sadak" },
                    { 3, "Biyoloji alanında kendimi geliştirmek istiyorum.", new DateTime(2023, 1, 5, 9, 53, 21, 504, DateTimeKind.Local).AddTicks(2483), "Yavuz", "Akduman", "yavuz-akduman" }
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bahçeşehir Üniversitesi" },
                    { 2, "Beykent Üniversitesi" },
                    { 3, "İstanbul Aydın Üniversitesi" },
                    { 4, "İstanbul Teknik Üniversitesi" },
                    { 5, "Orta Doğu Teknik Üniversitesi" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "BirthYear", "BranchId", "DateOfRegistration", "Experience", "FirstName", "Gender", "ImageUrl", "LastName", "Location", "PricePerHour", "UniversityId", "Url" },
                values: new object[,]
                {
                    { 1, "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.", 1985, 1, new DateTime(2023, 1, 5, 9, 53, 21, 504, DateTimeKind.Local).AddTicks(1169), 20, "Osman", 'E', "1.png", "Kıran", "İstanbul", 1500m, 1, "osman-kiran" },
                    { 2, "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.", 1975, 2, new DateTime(2023, 1, 5, 9, 53, 21, 504, DateTimeKind.Local).AddTicks(1176), 30, "Ahmet", 'E', "2.png", "Acar", "Ankara", 2000m, 2, "ahmet-acar" },
                    { 3, "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.", 1993, 3, new DateTime(2023, 1, 5, 9, 53, 21, 504, DateTimeKind.Local).AddTicks(1180), 10, "Hatice", 'K', "3.png", "Özer", "İstanbul", 2500m, 3, "hatice-ozer" },
                    { 4, "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.", 1995, 1, new DateTime(2023, 1, 5, 9, 53, 21, 504, DateTimeKind.Local).AddTicks(1184), 8, "Cemre", 'E', "4.png", "Şenel", "İstanbul", 2200m, 4, "cemre-senel" }
                });

            migrationBuilder.InsertData(
                table: "StudentTeachers",
                columns: new[] { "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeachers_TeacherId",
                table: "StudentTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_BranchId",
                table: "Teachers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UniversityId",
                table: "Teachers",
                column: "UniversityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentTeachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Universities");
        }
    }
}
