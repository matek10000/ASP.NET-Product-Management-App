using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductData.Migrations
{
    /// <inheritdoc />
    public partial class _301220234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f932af2c-268e-4709-8bc1-4d92a9fa35fe", "8f9af036-128e-44e6-863a-2bf5ffa43806" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f932af2c-268e-4709-8bc1-4d92a9fa35fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f9af036-128e-44e6-863a-2bf5ffa43806");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "118c70eb-102c-458a-add3-895353bac9e0", "118c70eb-102c-458a-add3-895353bac9e0", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8da448c-b319-4812-9394-5d44c6ab11f7", 0, "953f2415-f030-4bdd-b46f-fc19ccf16421", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "MATEK", "AQAAAAEAACcQAAAAECo/uyqEOy35Lwmb7yEGJHC6e4EGtQhZTBQvsHtkcCgIZI7hf656ipppKKSYf+CQqg==", null, false, "5130e710-a6b8-4e1d-a3e8-3704a8f74593", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LowStock", "ProductionDate" },
                values: new object[] { true, new DateTime(2023, 12, 30, 14, 0, 32, 750, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 14, 0, 32, 750, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 14, 0, 32, 750, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 14, 0, 32, 750, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 14, 0, 32, 750, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 14, 0, 32, 750, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 14, 0, 32, 750, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "118c70eb-102c-458a-add3-895353bac9e0", "e8da448c-b319-4812-9394-5d44c6ab11f7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "118c70eb-102c-458a-add3-895353bac9e0", "e8da448c-b319-4812-9394-5d44c6ab11f7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "118c70eb-102c-458a-add3-895353bac9e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8da448c-b319-4812-9394-5d44c6ab11f7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f932af2c-268e-4709-8bc1-4d92a9fa35fe", "f932af2c-268e-4709-8bc1-4d92a9fa35fe", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8f9af036-128e-44e6-863a-2bf5ffa43806", 0, "f853b538-928d-42e3-a77d-2650dbc5074c", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "MATEK", "AQAAAAEAACcQAAAAEN2oUF65D090PHps04e+lTXayrFKi7bs9cJNhooI1lDabgZ/oSA9VVL8nS/Fm5s6wg==", null, false, "f307a7cd-ba7c-4cfb-84c6-d834aa51ada8", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LowStock", "ProductionDate" },
                values: new object[] { false, new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f932af2c-268e-4709-8bc1-4d92a9fa35fe", "8f9af036-128e-44e6-863a-2bf5ffa43806" });
        }
    }
}
