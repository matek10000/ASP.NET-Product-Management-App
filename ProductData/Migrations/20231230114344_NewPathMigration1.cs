using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductData.Migrations
{
    /// <inheritdoc />
    public partial class NewPathMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64985ef9-cd78-4a57-b3f2-5027e597ca5e", "bfe813e7-7367-4589-930a-848cb71fb7eb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64985ef9-cd78-4a57-b3f2-5027e597ca5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfe813e7-7367-4589-930a-848cb71fb7eb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7ba20cd-4261-462d-875c-d83ac4445b36", "a7ba20cd-4261-462d-875c-d83ac4445b36", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e05490bd-89fe-419f-a12c-dae65832f3f8", 0, "c76a56e3-3850-48cf-8412-a139c716ba7d", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "MATEK", "AQAAAAEAACcQAAAAEHRhkZp65xd8XyvWOwxz7hJi+HYfsLj+UrQovEEBvaUKJUWxYE6wvyjQL0Q7zl3QAQ==", null, false, "110a0513-4724-4f48-9ed2-3303a00ac137", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 43, 44, 296, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 43, 44, 296, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 43, 44, 296, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 43, 44, 296, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 43, 44, 296, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 43, 44, 296, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 43, 44, 296, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a7ba20cd-4261-462d-875c-d83ac4445b36", "e05490bd-89fe-419f-a12c-dae65832f3f8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7ba20cd-4261-462d-875c-d83ac4445b36", "e05490bd-89fe-419f-a12c-dae65832f3f8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7ba20cd-4261-462d-875c-d83ac4445b36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e05490bd-89fe-419f-a12c-dae65832f3f8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64985ef9-cd78-4a57-b3f2-5027e597ca5e", "64985ef9-cd78-4a57-b3f2-5027e597ca5e", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bfe813e7-7367-4589-930a-848cb71fb7eb", 0, "4bb8ec69-3d34-48c3-b282-1a6a8482f74e", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "MATEK", "AQAAAAEAACcQAAAAEJOF+o7VnYZhz/WouqEq4yhKm4gkkSLjrjPOWA5ycQFwD4IdYcfUbvqWTCT1oGbWlg==", null, false, "89385c84-33d1-4006-8c4d-0301dbd62558", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 21, 15, 46, 2, 877, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 21, 15, 46, 2, 877, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 21, 15, 46, 2, 877, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 21, 15, 46, 2, 877, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 21, 15, 46, 2, 877, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 21, 15, 46, 2, 877, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 21, 15, 46, 2, 877, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "64985ef9-cd78-4a57-b3f2-5027e597ca5e", "bfe813e7-7367-4589-930a-848cb71fb7eb" });
        }
    }
}
