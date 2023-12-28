using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductData.Migrations
{
    /// <inheritdoc />
    public partial class Migration2112 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e04124c-eca8-4223-ac55-c3809fe379a6", "6bba8984-5378-4e66-997b-fa853de092f2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e04124c-eca8-4223-ac55-c3809fe379a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bba8984-5378-4e66-997b-fa853de092f2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2e04124c-eca8-4223-ac55-c3809fe379a6", "2e04124c-eca8-4223-ac55-c3809fe379a6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bba8984-5378-4e66-997b-fa853de092f2", 0, "05e68049-82d0-40dc-a376-338dfec41804", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "MATEK", "AQAAAAEAACcQAAAAEIi0g8R2Dnc8GhBLDnEPwpP+3r1gsHSMHwqA/NMdDh9Py/yPC1u9DAfm0WqCduMV4g==", null, false, "a12c597e-3fe4-42cd-b3db-9fc131951187", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 51, 56, 581, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 51, 56, 581, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 51, 56, 581, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 51, 56, 581, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 51, 56, 581, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 51, 56, 581, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 51, 56, 581, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2e04124c-eca8-4223-ac55-c3809fe379a6", "6bba8984-5378-4e66-997b-fa853de092f2" });
        }
    }
}
