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
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Id = table.Column<string>(type: "TEXT", nullable: false),
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
                    UniversityId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
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
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentId1 = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherId1 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTeachers", x => new { x.StudentId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Teachers_TeacherId1",
                        column: x => x.TeacherId1,
                        principalTable: "Teachers",
                        principalColumn: "Id");
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
                table: "StudentTeachers",
                columns: new[] { "StudentId", "TeacherId", "StudentId1", "TeacherId1" },
                values: new object[,]
                {
                    { 1, 1, null, null },
                    { 1, 3, null, null },
                    { 2, 1, null, null },
                    { 3, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "DateOfRegistration", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Url", "UserName" },
                values: new object[,]
                {
                    { "10a0b796-9149-4864-8dd7-41e467a940a4", "Biyoloji alanında kendimi geliştirmek istiyorum.", 0, "047f24b8-fe3e-4194-8095-52ac663701fb", new DateTime(2023, 1, 6, 11, 34, 28, 768, DateTimeKind.Local).AddTicks(3769), null, false, "Yavuz", "Akduman", false, null, null, null, null, null, false, "e0d35f3e-da86-43d1-b88a-79cfc48e9536", false, "yavuz-akduman", null },
                    { "6c49f23f-6e33-4dbe-864b-ecc03f30380f", "Matematik dersinde kendimi geliştirmek istiyorum.", 0, "8cd61439-cfd2-498d-aa9f-a5a974917f45", new DateTime(2023, 1, 6, 11, 34, 28, 768, DateTimeKind.Local).AddTicks(3723), null, false, "Harun", "Özer", false, null, null, null, null, null, false, "ec41985e-e9a7-4bee-85fe-1159bf8455ac", false, "harun-ozer", null },
                    { "ae3b08f8-7f20-400b-99e4-7294aa3ebbf7", "Fizik dersinde kendimi geliştirmek istiyorum.", 0, "b056535d-3091-4e0d-a07e-e9c401bd53dc", new DateTime(2023, 1, 6, 11, 34, 28, 768, DateTimeKind.Local).AddTicks(3752), null, false, "Selami", "Sadak", false, null, null, null, null, null, false, "607528a1-d90b-45af-a40c-fb813d1f7a6f", false, "selami-sadak", null }
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
                columns: new[] { "Id", "About", "AccessFailedCount", "BirthYear", "BranchId", "ConcurrencyStamp", "DateOfRegistration", "Email", "EmailConfirmed", "Experience", "FirstName", "Gender", "ImageUrl", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PricePerHour", "SecurityStamp", "TwoFactorEnabled", "UniversityId", "Url", "UserName" },
                values: new object[,]
                {
                    { "3771078d-d2be-4538-bb85-ef653c8be984", "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.", 0, 1975, 2, "fe84919e-8dfd-4769-b376-509922aa126b", new DateTime(2023, 1, 6, 11, 34, 28, 768, DateTimeKind.Local).AddTicks(168), null, false, 30, "Ahmet", 'E', "2.png", "Acar", "Ankara", false, null, null, null, null, null, false, 2000m, "974f5ef4-f9ea-4321-934c-c87623eed67a", false, 2, "ahmet-acar", null },
                    { "3fbcc31b-8c93-43dd-a062-e1fd2022c45a", "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.", 0, 1993, 3, "79f331c0-6167-42c1-805a-64976628d87e", new DateTime(2023, 1, 6, 11, 34, 28, 768, DateTimeKind.Local).AddTicks(193), null, false, 10, "Hatice", 'K', "3.png", "Özer", "İstanbul", false, null, null, null, null, null, false, 2500m, "36353e9f-d364-4416-8787-757ea4e59b0a", false, 3, "hatice-ozer", null },
                    { "5bee4523-2e16-4f0c-a1ee-93c1f7e9cf5d", "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.", 0, 1995, 1, "70c7f7e1-418f-423f-9bdd-7efb4a20a04d", new DateTime(2023, 1, 6, 11, 34, 28, 768, DateTimeKind.Local).AddTicks(210), null, false, 8, "Cemre", 'E', "4.png", "Şenel", "İstanbul", false, null, null, null, null, null, false, 2200m, "e2b216a7-99f8-4d12-b49f-598f48144b39", false, 4, "cemre-senel", null },
                    { "da5dc2b0-d0de-4299-938a-84e0c0562bea", "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.", 0, 1985, 1, "7e30fef9-6a17-4e0d-be3c-a0bc041d13b4", new DateTime(2023, 1, 6, 11, 34, 28, 768, DateTimeKind.Local).AddTicks(146), null, false, 20, "Osman", 'E', "1.png", "Kıran", "İstanbul", false, null, null, null, null, null, false, 1500m, "f94e10eb-3a57-4779-b756-0cceab73f92c", false, 1, "osman-kiran", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeachers_StudentId1",
                table: "StudentTeachers",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeachers_TeacherId1",
                table: "StudentTeachers",
                column: "TeacherId1");

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
