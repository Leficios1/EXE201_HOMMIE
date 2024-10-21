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
                    RoleName = "Admin",
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
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "customer",
                    Email = "customer@gmail.com",
                    Phone = "1234567890",
                    Password = "12345",
                    DateOfBirth = new DateTime(2002, 05, 23),
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    Status = true,
                    RoleId = 2,
                    CreatedAt = DateTime.UtcNow
                },
                new User
                {
                    UserId = 2,
                    Name = "employer",
                    Email = "employer@gmail.com",
                    Phone = "0987654321",
                    Password = "67890",
                    DateOfBirth = new DateTime(1990, 07, 12),
                    AvatarUrl = "https://example.com/avatar2.jpg",
                    Gender = "Female",
                    Status = true,
                    RoleId = 3,
                    CreatedAt = DateTime.UtcNow
                },

new User
{
    UserId = 3,
    Name = "worker1",
    Email = "worker1@gmail.com",
    Phone = "1122334455",
    Password = "worker123",
    DateOfBirth = new DateTime(1995, 02, 10),
    AvatarUrl = "https://example.com/avatar3.jpg",
    Gender = "Male",
    Status = true,
    RoleId = 4,
    CreatedAt = DateTime.UtcNow
},

new User
{
    UserId = 4,
    Name = "worker2",
    Email = "worker2@gmail.com",
    Phone = "9988776655",
    Password = "worker456",
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
    Name = "admin",
    Email = "admin@gmail.com",
    Phone = "1231231234",
    Password = "admin789",
    DateOfBirth = new DateTime(1985, 04, 18),
    AvatarUrl = "https://example.com/avatar5.jpg",
    Gender = "Male",
    Status = true,
    RoleId = 1,
    CreatedAt = DateTime.UtcNow
},

    new User
    {
        UserId = 6,
        Name = "customer2",
        Email = "customer2@gmail.com",
        Phone = "4567891230",
        Password = "cust2345",
        DateOfBirth = new DateTime(2000, 08, 15),
        AvatarUrl = "https://example.com/avatar6.jpg",
        Gender = "Female",
        Status = true,
        RoleId = 2,
        CreatedAt = DateTime.UtcNow
    }
                );

            modelBuilder.Entity<EWallet>().HasData(

                new EWallet
                {
                    WalletId = 1,
                    UserId = 1,
                    Balance = 0,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                new EWallet
                {
                    WalletId = 2,
                    UserId = 2,
                    Balance = 0,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                new EWallet
                {
                    WalletId = 3,
                    UserId = 3,
                    Balance = 0,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                new EWallet
                {
                    WalletId = 4,
                    UserId = 4,
                    Balance = 0,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                new EWallet
                {
                    WalletId = 5,
                    UserId = 5,
                    Balance = 0,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                new EWallet
                {
                    WalletId = 6,
                    UserId = 6,
                    Balance = 0,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                }

                );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "combo1",
                    Price = 100000
                }
            );
        }
    }
}
