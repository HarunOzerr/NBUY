using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93da8d85-2e0b-4c58-9d5c-2c986538fbfc", "491edfe4-ce74-4e5f-9e20-b17fb164efee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "facdfb32-9f47-49f1-8e1e-77a5fb81f4a3", "cfeea506-6185-48ca-94ec-6a1b892f14d3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93da8d85-2e0b-4c58-9d5c-2c986538fbfc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "facdfb32-9f47-49f1-8e1e-77a5fb81f4a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "491edfe4-ce74-4e5f-9e20-b17fb164efee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfeea506-6185-48ca-94ec-6a1b892f14d3");

            migrationBuilder.AddColumn<string>(
                name: "Deneme",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "499bd4cb-bf66-4b6f-88d6-916387a8e453", null, "User rolü", "User", "USER" },
                    { "6aee362e-1d7a-4290-88fc-76453a4cd53c", null, "Admin rolü", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01c5033d-1d70-46ad-a210-c474a1f4d26a", 0, "Çek cd. Senet sk. Fatura ap.", "İstanbul", "3bf81063-9230-40da-8fad-a873f240ec7c", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEIjsw6ZksAM+XpC4pWuvd9bcAi8XmESfi/3+Nqh5DMGr1SsAfUfQrjSsu53dVJxN6g==", "5555555555", false, "911bb689-5ba5-426b-ab2d-6b42a34a24e9", false, "admin" },
                    { "450d18e1-60d8-4561-b8dc-ef4544f77f06", 0, "Akasya cd. Orkide sk. Gül ap.", "İzmir", "ee68ca4f-9da3-4d38-b506-51ffbe2d80e0", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEDjxPM2hkqqnBwR5BQHzJcHIJSFRrl8Z/r/UsVRB8B7N0KrHuGkQhxaO6W2YR9LfOg==", "4444444444", false, "a9fe00b6-03fd-46be-9e16-b0bdad24a957", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Deneme", "UserId" },
                values: new object[] { null, "01c5033d-1d70-46ad-a210-c474a1f4d26a" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deneme", "UserId" },
                values: new object[] { null, "450d18e1-60d8-4561-b8dc-ef4544f77f06" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6aee362e-1d7a-4290-88fc-76453a4cd53c", "01c5033d-1d70-46ad-a210-c474a1f4d26a" },
                    { "499bd4cb-bf66-4b6f-88d6-916387a8e453", "450d18e1-60d8-4561-b8dc-ef4544f77f06" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6aee362e-1d7a-4290-88fc-76453a4cd53c", "01c5033d-1d70-46ad-a210-c474a1f4d26a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "499bd4cb-bf66-4b6f-88d6-916387a8e453", "450d18e1-60d8-4561-b8dc-ef4544f77f06" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "499bd4cb-bf66-4b6f-88d6-916387a8e453");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aee362e-1d7a-4290-88fc-76453a4cd53c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01c5033d-1d70-46ad-a210-c474a1f4d26a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "450d18e1-60d8-4561-b8dc-ef4544f77f06");

            migrationBuilder.DropColumn(
                name: "Deneme",
                table: "Cards");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "93da8d85-2e0b-4c58-9d5c-2c986538fbfc", null, "User rolü", "User", "USER" },
                    { "facdfb32-9f47-49f1-8e1e-77a5fb81f4a3", null, "Admin rolü", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "491edfe4-ce74-4e5f-9e20-b17fb164efee", 0, "Akasya cd. Orkide sk. Gül ap.", "İzmir", "c2597080-6f40-4461-b682-9baad81ab85f", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEP3QwPgbTGDZAjEuAFmu6tSJ4bbTj2mKyFRfOiQcAWF4Uto90Aes5eZ86B5FKlM+Uw==", "4444444444", false, "ef603a08-6237-4609-973e-8c31569bf88a", false, "user" },
                    { "cfeea506-6185-48ca-94ec-6a1b892f14d3", 0, "Çek cd. Senet sk. Fatura ap.", "İstanbul", "ffa6b106-3b50-48dc-a086-1c8a596fe843", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEPQTqX00UihkttKtrWMO4ZhkyJTeYVvg4eB0OHjT9PjSlnVkn1MicMcYgnrdMVVKOw==", "5555555555", false, "bc03fd21-5257-4b40-ba70-c8187d4d2f09", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "cfeea506-6185-48ca-94ec-6a1b892f14d3");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "491edfe4-ce74-4e5f-9e20-b17fb164efee");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "93da8d85-2e0b-4c58-9d5c-2c986538fbfc", "491edfe4-ce74-4e5f-9e20-b17fb164efee" },
                    { "facdfb32-9f47-49f1-8e1e-77a5fb81f4a3", "cfeea506-6185-48ca-94ec-6a1b892f14d3" }
                });
        }
    }
}
