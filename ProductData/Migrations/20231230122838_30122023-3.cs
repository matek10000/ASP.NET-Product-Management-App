using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductData.Migrations
{
    /// <inheritdoc />
    public partial class _301220233 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5bc9ea9b-44e5-43ad-8c40-f2b84af2dc6e", "0f2f70b6-e152-49f5-aba5-1859210e9c63" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bc9ea9b-44e5-43ad-8c40-f2b84af2dc6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f2f70b6-e152-49f5-aba5-1859210e9c63");

            migrationBuilder.AddColumn<bool>(
                name: "LowStock",
                table: "products",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "LowStock", "ProductionDate" },
                values: new object[] { false, new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LowStock", "ProductionDate" },
                values: new object[] { false, new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LowStock", "ProductionDate" },
                values: new object[] { false, new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LowStock", "ProductionDate" },
                values: new object[] { false, new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LowStock", "ProductionDate" },
                values: new object[] { false, new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LowStock", "ProductionDate" },
                values: new object[] { false, new DateTime(2023, 12, 30, 13, 28, 38, 90, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f932af2c-268e-4709-8bc1-4d92a9fa35fe", "8f9af036-128e-44e6-863a-2bf5ffa43806" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "LowStock",
                table: "products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bc9ea9b-44e5-43ad-8c40-f2b84af2dc6e", "5bc9ea9b-44e5-43ad-8c40-f2b84af2dc6e", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0f2f70b6-e152-49f5-aba5-1859210e9c63", 0, "4a08086b-ac8f-4245-8308-1c8911db35d4", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "MATEK", "AQAAAAEAACcQAAAAEEBhCiD1e4Am8qiKf+22EGKd2AaDsZg1ySZVmCvcpLgxzjo71MAuTFzos80MJEMuQA==", null, false, "5e294dbc-4a76-48eb-aefe-33b5fcc77be4", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 57, 15, 185, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 57, 15, 185, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 57, 15, 185, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 57, 15, 185, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 57, 15, 185, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 57, 15, 185, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 57, 15, 185, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5bc9ea9b-44e5-43ad-8c40-f2b84af2dc6e", "0f2f70b6-e152-49f5-aba5-1859210e9c63" });
        }
    }
}
