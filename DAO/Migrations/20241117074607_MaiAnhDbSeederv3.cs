using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    public partial class MaiAnhDbSeederv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 4,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 5,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hours",
                value: "1-2h");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "Hours",
                value: "1-2h");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "Hours",
                value: "1-2h");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "Hours",
                value: "1-2h");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "Hours",
                value: "2-3h");

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8103), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8107), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8109), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8110), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8112), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8113), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8114), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8116), new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 46, 6, 657, DateTimeKind.Utc).AddTicks(8005));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 4,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 5,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6424), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6426), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6428), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6429), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6431), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6434), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6435), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6356));
        }
    }
}
