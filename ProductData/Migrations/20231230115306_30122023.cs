using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductData.Migrations
{
    /// <inheritdoc />
    public partial class _30122023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "fb2a1460-16e3-4271-b831-46901f016023", "fb2a1460-16e3-4271-b831-46901f016023", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "701f7573-7879-4ec4-ab73-e99580e97fe8", 0, "86a20db8-4f27-4004-b2ef-f4b067cc5a00", "mateusz@gmail.com", true, false, null, "MATEUSZ@GMAIL.COM", "MATEK", "AQAAAAEAACcQAAAAECbSLJ2fuuEQHzLUaUEXBrRQRpGeJmnSgCOQArcy7nTFYGOfWjhsHqe1HAdDe6pADw==", null, false, "15cb7a41-aacf-4579-aabf-9691062b56cd", false, "matek" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 53, 6, 232, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 53, 6, 232, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 53, 6, 232, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 53, 6, 232, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 53, 6, 232, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 53, 6, 232, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductionDate",
                value: new DateTime(2023, 12, 30, 12, 53, 6, 232, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb2a1460-16e3-4271-b831-46901f016023", "701f7573-7879-4ec4-ab73-e99580e97fe8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb2a1460-16e3-4271-b831-46901f016023", "701f7573-7879-4ec4-ab73-e99580e97fe8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb2a1460-16e3-4271-b831-46901f016023");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "701f7573-7879-4ec4-ab73-e99580e97fe8");

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
    }
}
