using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductData.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "835aff14-a60d-4ae1-95ac-4227dfbf80e8", "835aff14-a60d-4ae1-95ac-4227dfbf80e8", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8e4ab21-ee5f-4ab4-9b94-28c742029794", 0, "307e3a70-912d-4771-94d5-24d2bf48e36d", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEDigN87lekdP1ffRZUyE6jcLSHnLhnGVsZcrO8lCCtMOQFJDFXE0QmKxkSmMtW4AZw==", null, false, "5eefeb60-d964-4637-b828-85930c1ff621", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Manufacturer", "Name", "Price", "ProductionDate" },
                values: new object[] { "Najlepsze polskie jablka!", "Polskie Jablko", "Jabłko", 5.0m, new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Manufacturer", "Name", "Price", "ProductionDate" },
                values: new object[] { "Zakochaj sie w marchwi!", "MarchekoweLove", "Marchewka", 7.0m, new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Description", "Manufacturer", "Name", "Price", "ProductionDate" },
                values: new object[,]
                {
                    { 3, "Potrzebna mi gotówka - oto twoja gruszka!", "GruGruPOL", "Gruszka", 9.0m, new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3178) },
                    { 4, "Produkt z GreenPoland", "GreenPoland", "Sałata", 7.5m, new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3179) },
                    { 5, "Produkt z GreenPoland", "GreenPoland", "Kapusta", 7.0m, new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3181) },
                    { 6, "Produkt z GreenPoland", "GreenPoland", "Rukola", 12.0m, new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3183) },
                    { 7, "Le migliori noci solo con noi!", "Italiano", "Orzech włoski", 13.0m, new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3185) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "835aff14-a60d-4ae1-95ac-4227dfbf80e8", "e8e4ab21-ee5f-4ab4-9b94-28c742029794" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "835aff14-a60d-4ae1-95ac-4227dfbf80e8", "e8e4ab21-ee5f-4ab4-9b94-28c742029794" });

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835aff14-a60d-4ae1-95ac-4227dfbf80e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8e4ab21-ee5f-4ab4-9b94-28c742029794");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Manufacturer", "Name", "Price", "ProductionDate" },
                values: new object[] { "Description1", "Manufacturer1", "Product1", 10.0m, new DateTime(2023, 12, 1, 18, 57, 33, 390, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Manufacturer", "Name", "Price", "ProductionDate" },
                values: new object[] { "Description2", "Manufacturer2", "Product2", 20.0m, new DateTime(2023, 12, 1, 18, 57, 33, 390, DateTimeKind.Local).AddTicks(2838) });
        }
    }
}
