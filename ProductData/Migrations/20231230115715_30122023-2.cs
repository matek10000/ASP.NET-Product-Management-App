using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductData.Migrations
{
    /// <inheritdoc />
    public partial class _301220232 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
