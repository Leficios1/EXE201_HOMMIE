using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    public partial class MaiAnhDbSeederv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AvatarUrl", "CreatedAt", "DateOfBirth", "Email", "Gender", "Name", "Password", "Phone", "RoleId", "Status" },
                values: new object[,]
                {
                    { 6, "https://example.com/avatar1.jpg", new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6353), new DateTime(1995, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "huong.nguyen@example.com", "Female", "Nguyễn Thị Hương", "password123", "0912345678", 3, true },
                    { 7, "https://example.com/avatar2.jpg", new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6354), new DateTime(1993, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mai.tran@example.com", "Female", "Trần Thị Mai", "password456", "0923456789", 3, true },
                    { 8, "https://example.com/avatar3.jpg", new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6355), new DateTime(1997, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "lan.pham@example.com", "Female", "Phạm Thị Lan", "password789", "0934567890", 3, true },
                    { 9, "https://example.com/avatar4.jpg", new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6356), new DateTime(1994, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "anh.le@example.com", "Female", "Lê Thị Ánh", "passwordabc", "0945678901", 3, true }
                });

            migrationBuilder.InsertData(
                table: "EWallets",
                columns: new[] { "WalletId", "Balance", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 6, 300000.00m, new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6432), 6 },
                    { 7, 300000.00m, new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6434), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6434), 7 },
                    { 8, 300000.00m, new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6435), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6435), 8 },
                    { 9, 300000.00m, new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 11, 17, 7, 26, 25, 193, DateTimeKind.Utc).AddTicks(6437), 9 }
                });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1,
                column: "UserId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3,
                column: "UserId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 4,
                column: "UserId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 5,
                column: "UserId",
                value: 9);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 4,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 5,
                column: "AppliedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8653), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8681), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8683), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8684), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8686), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "SentAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 4,
                column: "UserId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 5,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8582));
        }
    }
}
