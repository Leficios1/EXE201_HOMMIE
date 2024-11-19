using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    public partial class MaiAnhDbSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "Price" },
                values: new object[] { "Combo 1: Lau nhà, quét nhà", 80000m });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "Price" },
                values: new object[,]
                {
                    { 2, "Combo 2: Giặt đồ, ủi đồ", 80000m },
                    { 3, "Combo 3: Lau nhà, quét nhà, dọn bếp", 100000m },
                    { 4, "Combo 4: Chăm sóc thú cưng (ăn uống, vệ sinh, tắm rửa)", 100000m },
                    { 5, "Combo 5: Tổng hợp (full option trên)", 200000m }
                });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 1,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1000000.00m, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8653), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 2,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 500000.00m, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8681), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 3,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 750000.00m, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8683), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 4,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 250000.00m, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8684), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 5,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 300000.00m, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8686), new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.InsertData(
                table: "JobPosts",
                columns: new[] { "JobId", "CreateDate", "Description", "EmployerId", "EndDate", "JobType", "Location", "NumberOfFloors", "Price", "SquareMeters", "StartDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8616), "Cần tìm nhân viên lau dọn văn phòng 2 lần mỗi tuần.", 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hồ Chí Minh", 1, 200000m, 100.5m, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Lau dọn văn phòng" },
                    { 2, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8619), "Tìm nhân viên giặt ủi đồ cho gia đình 2 lần mỗi tháng.", 2, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hồ Chí Minh", 1, 80000m, 150.0m, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Giặt ủi đồ gia đình" },
                    { 3, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8621), "Cần tìm người chăm sóc chó mèo trong thời gian đi công tác.", 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hồ Chí Minh", null, 150000m, null, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Chăm sóc thú cưng" },
                    { 4, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8623), "Cần tìm nhân viên dọn dẹp nhà cửa trước Tết.", 4, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hồ Chí Minh", 2, 300000m, 200.0m, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Dọn dẹp nhà cửa" },
                    { 5, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8625), "Cần nhân viên tổng hợp dịch vụ dọn dẹp và giặt ủi cho một căn hộ lớn.", 5, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hồ Chí Minh", 3, 500000m, 300.0m, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Tổng hợp dịch vụ dọn dẹp" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Content", "ReceiverId", "SenderId", "SentAt" },
                values: new object[,]
                {
                    { 1, "Chào John, bạn có thể giúp tôi một việc không?", 2, 1, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8731) },
                    { 2, "Chào Admin, tôi sẵn sàng giúp đỡ!", 1, 2, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8732) },
                    { 3, "Alice, bạn có biết cách làm việc này không?", 4, 3, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8733) },
                    { 4, "Vâng, tôi có thể giúp bạn với điều đó.", 3, 4, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8734) },
                    { 5, "Admin, tôi cần thông tin về dự án mới.", 1, 5, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8734) }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "ProfileId", "Availability", "Bio", "Experience", "RatingAvg", "Skills", "UserId" },
                values: new object[,]
                {
                    { 1, "Sẵn sàng làm việc theo giờ linh hoạt.", "Kỹ năng giúp việc tận tâm, có khả năng nấu ăn và dọn dẹp tốt.", "5 năm kinh nghiệm trong việc làm giúp việc tại gia đình và văn phòng.", 4.5m, "Nấu ăn, Giặt giũ, Lau nhà, Dọn dẹp, Chăm sóc thú cưng", 2 },
                    { 2, "Có thể làm việc vào cuối tuần.", "Người giúp việc chuyên nghiệp với kỹ năng nấu ăn đa dạng.", "4 năm kinh nghiệm phục vụ tại các gia đình và khách sạn.", 4.7m, "Nấu ăn, Lau nhà, Dọn dẹp, Giặt giũ, Quản lý thời gian", 3 },
                    { 3, "Sẵn sàng làm việc toàn thời gian.", "Chuyên gia giúp việc tận tâm với sự chú ý đến chi tiết.", "6 năm kinh nghiệm giúp việc cho nhiều gia đình, bao gồm việc chăm sóc thú cưng.", 4.6m, "Giặt giũ, Lau nhà, Dọn dẹp, Nấu ăn, Chăm sóc thú cưng", 4 },
                    { 4, "Có thể làm việc theo hợp đồng.", "Người giúp việc chu đáo, có khả năng làm nhiều việc cùng lúc.", "3 năm làm việc tại nhiều gia đình với mức độ hài lòng cao từ khách hàng.", 4.2m, "Dọn dẹp, Giặt giũ, Nấu ăn, Chăm sóc nhà cửa, Quản lý chi tiêu", 5 },
                    { 5, "Sẵn sàng làm việc theo yêu cầu của khách hàng.", "Chuyên viên dịch vụ giúp việc với kỹ năng giao tiếp tốt.", "7 năm kinh nghiệm trong lĩnh vực giúp việc tại nhà.", 4.8m, "Nấu ăn, Lau nhà, Giặt giũ, Dọn dẹp, Chăm sóc người cao tuổi", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[] { 5, "Manager" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "CreatedAt", "DateOfBirth", "Email", "Name", "Password", "RoleId" },
                values: new object[] { "https://example.com/avatar1.jpg", new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8575), new DateTime(1985, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "Admin User", "admin123", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Gender", "Name", "Password", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8578), "john.doe@example.com", "Male", "John Doe", "password123", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "Email", "Gender", "Name", "Password", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8580), new DateTime(1992, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Female", "Jane Smith", "password456", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8581), "alice.brown@example.com", "Alice Brown", "password789" });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "AppliedAt", "JobId", "Message", "Status", "TypeJobPost", "WorkerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8702), 1, "Tôi rất thích công việc này và muốn ứng tuyển.", "pending", 1, 3 },
                    { 2, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8704), 2, "Tôi có kinh nghiệm trong lĩnh vực giặt ủi.", "accepted", 1, 4 },
                    { 3, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8705), 3, "Tôi có nhiều kinh nghiệm chăm sóc thú cưng.", "rejected", 1, 5 },
                    { 4, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8706), 4, "Tôi sẵn sàng làm việc ngay.", "pending", 1, 2 },
                    { 5, new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8707), 5, "Tôi rất muốn tham gia vào dự án này.", "pending", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CategoryJobPosts",
                columns: new[] { "CategoryId", "JobPostId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "CreatedAt", "JobId", "Rating", "ReviewedId", "ReviewerId" },
                values: new object[,]
                {
                    { 1, "Công việc này rất tốt, tôi rất hài lòng!", new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8715), 1, 4.5m, 3, 2 },
                    { 2, "Alice làm việc rất chuyên nghiệp!", new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8717), 2, 5.0m, 4, 3 },
                    { 3, "Bob cần cải thiện một số kỹ năng.", new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8718), 3, 3.0m, 5, 4 },
                    { 4, "John đã làm tốt công việc!", new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8719), 4, 4.0m, 2, 5 },
                    { 5, "Alice rất chăm chỉ và tận tâm!", new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8719), 5, 4.8m, 4, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateOfBirth", "Email", "Name", "Password", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 18, 20, 174, DateTimeKind.Utc).AddTicks(8582), new DateTime(1987, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.johnson@example.com", "Bob Johnson", "password101", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryJobPosts",
                keyColumns: new[] { "CategoryId", "JobPostId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryJobPosts",
                keyColumns: new[] { "CategoryId", "JobPostId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryJobPosts",
                keyColumns: new[] { "CategoryId", "JobPostId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryJobPosts",
                keyColumns: new[] { "CategoryId", "JobPostId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryJobPosts",
                keyColumns: new[] { "CategoryId", "JobPostId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "JobId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "Price" },
                values: new object[] { "combo1", 100000m });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 1,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0m, new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9823), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 2,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0m, new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9825), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 3,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0m, new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9827), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 4,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0m, new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9828), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "EWallets",
                keyColumn: "WalletId",
                keyValue: 5,
                columns: new[] { "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 0m, new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "CreatedAt", "DateOfBirth", "Email", "Name", "Password", "RoleId" },
                values: new object[] { "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9794), new DateTime(2002, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer@gmail.com", "customer", "12345", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Gender", "Name", "Password", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9797), "employer@gmail.com", "Female", "employer", "67890", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateOfBirth", "Email", "Gender", "Name", "Password", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9798), new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "worker1@gmail.com", "Male", "worker1", "worker123", 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "Name", "Password" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9799), "worker2@gmail.com", "worker2", "worker456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateOfBirth", "Email", "Name", "Password", "RoleId" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9801), new DateTime(1985, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "admin", "admin789", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AvatarUrl", "CreatedAt", "DateOfBirth", "Email", "Gender", "Name", "Password", "Phone", "RoleId", "Status" },
                values: new object[] { 6, "https://example.com/avatar6.jpg", new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9802), new DateTime(2000, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer2@gmail.com", "Female", "customer2", "cust2345", "4567891230", 2, true });

            migrationBuilder.InsertData(
                table: "EWallets",
                columns: new[] { "WalletId", "Balance", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6, 0m, new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9831), new DateTime(2024, 11, 17, 7, 11, 45, 546, DateTimeKind.Utc).AddTicks(9831), 6 });
        }
    }
}
