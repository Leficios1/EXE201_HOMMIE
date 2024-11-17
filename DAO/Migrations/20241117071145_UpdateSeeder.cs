using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    public partial class UpdateSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9823), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9825), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9827), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9828), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9831), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9802));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7546), new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7549), new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7550), new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7552), new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7516));
        }
    }
}
