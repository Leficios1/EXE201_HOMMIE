using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model.Context
{
    public static class HomieContextSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = 1,
                    RoleName = "Admin"
                },
                new Role
                {
                    RoleId = 2,
                    RoleName = "Customer"
                },
                new Role
                {
                    RoleId = 3,
                    RoleName = "Employee"
                },
                new Role
                {
                    RoleId = 4,
                    RoleName = "Staff"
                },
                new Role
                {
                    RoleId = 5,
                    RoleName = "Manager"
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "Admin User",
                    Email = "admin@example.com",
                    Phone = "1234567890",
                    Password = "admin123",
                    DateOfBirth = new DateTime(1985, 4, 18),
                    AvatarUrl = "https://example.com/avatar1.jpg",
                    Gender = "Male",
                    Status = true,
                    RoleId = 1,  
                    CreatedAt = DateTime.UtcNow
                },
                new User
                {
                    UserId = 2,
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    Phone = "0987654321",
                    Password = "password123",
                    DateOfBirth = new DateTime(1990, 7, 12),
                    AvatarUrl = "https://example.com/avatar2.jpg",
                    Gender = "Male",
                    Status = true,
                    RoleId = 2, 
                    CreatedAt = DateTime.UtcNow
                },
                new User
                {
                    UserId = 3,
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com",
                    Phone = "1122334455",
                    Password = "password456",
                    DateOfBirth = new DateTime(1992, 5, 10),
                    AvatarUrl = "https://example.com/avatar3.jpg",
                    Gender = "Female",
                    Status = true,
                    RoleId = 3,  
                    CreatedAt = DateTime.UtcNow
                },
                new User
                {
                    UserId = 4,
                    Name = "Alice Brown",
                    Email = "alice.brown@example.com",
                    Phone = "9988776655",
                    Password = "password789",
                    DateOfBirth = new DateTime(1988, 11, 30),
                    AvatarUrl = "https://example.com/avatar4.jpg",
                    Gender = "Female",
                    Status = false,
                    RoleId = 4,
                    CreatedAt = DateTime.UtcNow
                },
                new User
                {
                    UserId = 5,
                    Name = "Bob Johnson",
                    Email = "bob.johnson@example.com",
                    Phone = "1231231234",
                    Password = "password101",
                    DateOfBirth = new DateTime(1987, 2, 18),
                    AvatarUrl = "https://example.com/avatar5.jpg",
                    Gender = "Male",
                    Status = true,
                    RoleId = 5,  
                    CreatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "Combo 1: Lau nhà, quét nhà",
                    Price = 80000 
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Combo 2: Giặt đồ, ủi đồ",
                    Price = 80000 
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Combo 3: Lau nhà, quét nhà, dọn bếp",
                    Price = 100000 
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Combo 4: Chăm sóc thú cưng (ăn uống, vệ sinh, tắm rửa)",
                    Price = 100000 
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "Combo 5: Tổng hợp (full option trên)",
                    Price = 200000 
                }
            );

            modelBuilder.Entity<JobPost>().HasData(
                new JobPost
                {
                    JobId = 1,
                    EmployerId = 1, 
                    Title = "Lau dọn văn phòng",
                    Description = "Cần tìm nhân viên lau dọn văn phòng 2 lần mỗi tuần.",
                    Location = "Hồ Chí Minh",
                    SquareMeters = 100.5m,
                    NumberOfFloors = 1,
                    StartDate = new DateTime(2024, 11, 10),
                    EndDate = new DateTime(2025, 11, 10),
                    Price = 200000,
                    Status = "Open",
                    CreateDate = DateTime.UtcNow,
                    JobType = 1 
                },
                new JobPost
                {
                    JobId = 2,
                    EmployerId = 2, 
                    Title = "Giặt ủi đồ gia đình",
                    Description = "Tìm nhân viên giặt ủi đồ cho gia đình 2 lần mỗi tháng.",
                    Location = "Hồ Chí Minh",
                    SquareMeters = 150.0m,
                    NumberOfFloors = 1,
                    StartDate = new DateTime(2024, 11, 15),
                    EndDate = new DateTime(2025, 11, 15),
                    Price = 80000,
                    Status = "Open",
                    CreateDate = DateTime.UtcNow,
                    JobType = 1 
                },
                new JobPost
                {
                    JobId = 3,
                    EmployerId = 3, 
                    Title = "Chăm sóc thú cưng",
                    Description = "Cần tìm người chăm sóc chó mèo trong thời gian đi công tác.",
                    Location = "Hồ Chí Minh",
                    SquareMeters = null,
                    NumberOfFloors = null,
                    StartDate = new DateTime(2024, 12, 1),
                    EndDate = new DateTime(2025, 1, 1),
                    Price = 150000,
                    Status = "Open",
                    CreateDate = DateTime.UtcNow,
                    JobType = 1 
                },
                new JobPost
                {
                    JobId = 4,
                    EmployerId = 4, 
                    Title = "Dọn dẹp nhà cửa",
                    Description = "Cần tìm nhân viên dọn dẹp nhà cửa trước Tết.",
                    Location = "Hồ Chí Minh",
                    SquareMeters = 200.0m,
                    NumberOfFloors = 2,
                    StartDate = new DateTime(2024, 12, 15),
                    EndDate = new DateTime(2024, 12, 30),
                    Price = 300000,
                    Status = "Open",
                    CreateDate = DateTime.UtcNow,
                    JobType = 1 
                },
                new JobPost
                {
                    JobId = 5,
                    EmployerId = 5, 
                    Title = "Tổng hợp dịch vụ dọn dẹp",
                    Description = "Cần nhân viên tổng hợp dịch vụ dọn dẹp và giặt ủi cho một căn hộ lớn.",
                    Location = "Hồ Chí Minh",
                    SquareMeters = 300.0m,
                    NumberOfFloors = 3,
                    StartDate = new DateTime(2024, 11, 20),
                    EndDate = new DateTime(2025, 11, 20),
                    Price = 500000,
                    Status = "Open",
                    CreateDate = DateTime.UtcNow,
                    JobType = 1 
                }
            );

            modelBuilder.Entity<CategoryJobPost>().HasData(
                new CategoryJobPost
                {
                    Id = 1,
                    CategoryId = 1, 
                    JobPostId = 1  
                },
                new CategoryJobPost
                {
                    Id = 2,
                    CategoryId = 2, 
                    JobPostId = 2  
                },
                new CategoryJobPost
                {
                    Id = 3,
                    CategoryId = 3, 
                    JobPostId = 3  
                },
                new CategoryJobPost
                {
                    Id = 4,
                    CategoryId = 4, 
                    JobPostId = 4  
                },
                new CategoryJobPost
                {
                    Id = 5,
                    CategoryId = 5, 
                    JobPostId = 5  
                }
            );


            modelBuilder.Entity<EWallet>().HasData(
                new EWallet
                {
                    WalletId = 1,
                    UserId = 1, 
                    Balance = 1000000.00m, 
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EWallet
                {
                    WalletId = 2,
                    UserId = 2, 
                    Balance = 500000.00m, 
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EWallet
                {
                    WalletId = 3,
                    UserId = 3, 
                    Balance = 750000.00m, 
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EWallet
                {
                    WalletId = 4,
                    UserId = 4, 
                    Balance = 250000.00m, 
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EWallet
                {
                    WalletId = 5,
                    UserId = 5, 
                    Balance = 300000.00m,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Application>().HasData(
                new Application
                {
                    Id = 1,
                    JobId = 1,
                    WorkerId = 3, 
                    Message = "Tôi rất thích công việc này và muốn ứng tuyển.",
                    Status = "pending",
                    AppliedAt = DateTime.UtcNow,
                    TypeJobPost = 1 
                },
                new Application
                {
                    Id = 2,
                    JobId = 2, 
                    WorkerId = 4, 
                    Message = "Tôi có kinh nghiệm trong lĩnh vực giặt ủi.",
                    Status = "accepted", 
                    AppliedAt = DateTime.UtcNow,
                    TypeJobPost = 1
                },
                new Application
                {
                    Id = 3,
                    JobId = 3,
                    WorkerId = 5, 
                    Message = "Tôi có nhiều kinh nghiệm chăm sóc thú cưng.",
                    Status = "rejected", 
                    AppliedAt = DateTime.UtcNow,
                    TypeJobPost = 1 
                },
                new Application
                {
                    Id = 4,
                    JobId = 4, 
                    WorkerId = 2, 
                    Message = "Tôi sẵn sàng làm việc ngay.",
                    Status = "pending", 
                    AppliedAt = DateTime.UtcNow,
                    TypeJobPost = 1 
                },
                new Application
                {
                    Id = 5,
                    JobId = 5,
                    WorkerId = 3, 
                    Message = "Tôi rất muốn tham gia vào dự án này.",
                    Status = "pending", 
                    AppliedAt = DateTime.UtcNow,
                    TypeJobPost = 1
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewId = 1,
                    JobId = 1, 
                    ReviewerId = 2, 
                    ReviewedId = 3, 
                    Rating = 4.5m, 
                    Comment = "Công việc này rất tốt, tôi rất hài lòng!",
                    CreatedAt = DateTime.UtcNow
                },
                new Review
                {
                    ReviewId = 2,
                    JobId = 2, 
                    ReviewerId = 3,
                    ReviewedId = 4,
                    Rating = 5.0m, 
                    Comment = "Alice làm việc rất chuyên nghiệp!",
                    CreatedAt = DateTime.UtcNow
                },
                new Review
                {
                    ReviewId = 3,
                    JobId = 3, 
                    ReviewerId = 4,
                    ReviewedId = 5,
                    Rating = 3.0m, 
                    Comment = "Bob cần cải thiện một số kỹ năng.",
                    CreatedAt = DateTime.UtcNow
                },
                new Review
                {
                    ReviewId = 4,
                    JobId = 4, 
                    ReviewerId = 5, 
                    ReviewedId = 2, 
                    Rating = 4.0m, 
                    Comment = "John đã làm tốt công việc!",
                    CreatedAt = DateTime.UtcNow
                },
                new Review
                {
                    ReviewId = 5,
                    JobId = 5, 
                    ReviewerId = 1, 
                    ReviewedId = 4, 
                    Rating = 4.8m, 
                    Comment = "Alice rất chăm chỉ và tận tâm!",
                    CreatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    MessageId = 1,
                    SenderId = 1, 
                    ReceiverId = 2, 
                    Content = "Chào John, bạn có thể giúp tôi một việc không?",
                    SentAt = DateTime.UtcNow
                },
                new Message
                {
                    MessageId = 2,
                    SenderId = 2, 
                    ReceiverId = 1, 
                    Content = "Chào Admin, tôi sẵn sàng giúp đỡ!",
                    SentAt = DateTime.UtcNow
                },
                new Message
                {
                    MessageId = 3,
                    SenderId = 3, 
                    ReceiverId = 4, 
                    Content = "Alice, bạn có biết cách làm việc này không?",
                    SentAt = DateTime.UtcNow
                },
                new Message
                {
                    MessageId = 4,
                    SenderId = 4, 
                    ReceiverId = 3, 
                    Content = "Vâng, tôi có thể giúp bạn với điều đó.",
                    SentAt = DateTime.UtcNow
                },
                new Message
                {
                    MessageId = 5,
                    SenderId = 5, 
                    ReceiverId = 1, 
                    Content = "Admin, tôi cần thông tin về dự án mới.",
                    SentAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Profiles>().HasData(
                new Profiles
                {
                    ProfileId = 1,
                    UserId = 2, // Giả sử là User John Doe
                    Bio = "Kỹ năng giúp việc tận tâm, có khả năng nấu ăn và dọn dẹp tốt.",
                    Skills = "Nấu ăn, Giặt giũ, Lau nhà, Dọn dẹp, Chăm sóc thú cưng",
                    Experience = "5 năm kinh nghiệm trong việc làm giúp việc tại gia đình và văn phòng.",
                    Availability = "Sẵn sàng làm việc theo giờ linh hoạt.",
                    RatingAvg = 4.5m
                },
                new Profiles
                {
                    ProfileId = 2,
                    UserId = 3, // Giả sử là User Jane Smith
                    Bio = "Người giúp việc chuyên nghiệp với kỹ năng nấu ăn đa dạng.",
                    Skills = "Nấu ăn, Lau nhà, Dọn dẹp, Giặt giũ, Quản lý thời gian",
                    Experience = "4 năm kinh nghiệm phục vụ tại các gia đình và khách sạn.",
                    Availability = "Có thể làm việc vào cuối tuần.",
                    RatingAvg = 4.7m
                },
                new Profiles
                {
                    ProfileId = 3,
                    UserId = 4, // Giả sử là User Alice Brown
                    Bio = "Chuyên gia giúp việc tận tâm với sự chú ý đến chi tiết.",
                    Skills = "Giặt giũ, Lau nhà, Dọn dẹp, Nấu ăn, Chăm sóc thú cưng",
                    Experience = "6 năm kinh nghiệm giúp việc cho nhiều gia đình, bao gồm việc chăm sóc thú cưng.",
                    Availability = "Sẵn sàng làm việc toàn thời gian.",
                    RatingAvg = 4.6m
                },
                new Profiles
                {
                    ProfileId = 4,
                    UserId = 5, // Giả sử là User Bob Johnson
                    Bio = "Người giúp việc chu đáo, có khả năng làm nhiều việc cùng lúc.",
                    Skills = "Dọn dẹp, Giặt giũ, Nấu ăn, Chăm sóc nhà cửa, Quản lý chi tiêu",
                    Experience = "3 năm làm việc tại nhiều gia đình với mức độ hài lòng cao từ khách hàng.",
                    Availability = "Có thể làm việc theo hợp đồng.",
                    RatingAvg = 4.2m
                },
                new Profiles
                {
                    ProfileId = 5,
                    UserId = 1, // Giả sử là User Admin
                    Bio = "Chuyên viên dịch vụ giúp việc với kỹ năng giao tiếp tốt.",
                    Skills = "Nấu ăn, Lau nhà, Giặt giũ, Dọn dẹp, Chăm sóc người cao tuổi",
                    Experience = "7 năm kinh nghiệm trong lĩnh vực giúp việc tại nhà.",
                    Availability = "Sẵn sàng làm việc theo yêu cầu của khách hàng.",
                    RatingAvg = 4.8m
                }
            );

            
        }
    }
}
