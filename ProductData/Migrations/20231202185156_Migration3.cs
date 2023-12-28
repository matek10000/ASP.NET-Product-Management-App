using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductData.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "835aff14-a60d-4ae1-95ac-4227dfbf80e8", "e8e4ab21-ee5f-4ab4-9b94-28c742029794" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835aff14-a60d-4ae1-95ac-4227dfbf80e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8e4ab21-ee5f-4ab4-9b94-28c742029794");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "835aff14-a60d-4ae1-95ac-4227dfbf80e8", "835aff14-a60d-4ae1-95ac-4227dfbf80e8", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8e4ab21-ee5f-4ab4-9b94-28c742029794", 0, "307e3a70-912d-4771-94d5-24d2bf48e36d", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEDigN87lekdP1ffRZUyE6jcLSHnLhnGVsZcrO8lCCtMOQFJDFXE0QmKxkSmMtW4AZw==", null, false, "5eefeb60-d964-4637-b828-85930c1ff621", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 2, 19, 48, 25, 636, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "835aff14-a60d-4ae1-95ac-4227dfbf80e8", "e8e4ab21-ee5f-4ab4-9b94-28c742029794" });
        }
    }
}
