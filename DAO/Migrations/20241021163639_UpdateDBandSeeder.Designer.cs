﻿// <auto-generated />
using System;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAO.Migrations
{
    [DbContext(typeof(HomieContext))]
    [Migration("20241021163639_UpdateDBandSeeder")]
    partial class UpdateDBandSeeder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAO.Model.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AppliedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeJobPost")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("DAO.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "combo1",
                            Price = 100000m
                        });
                });

            modelBuilder.Entity("DAO.Model.CategoryJobPost", b =>
                {
                    b.Property<int>("JobPostId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("JobPostId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryJobPosts");
                });

            modelBuilder.Entity("DAO.Model.EWallet", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WalletId"), 1L, 1);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("WalletId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("EWallets");

                    b.HasData(
                        new
                        {
                            WalletId = 1,
                            Balance = 0m,
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7543),
                            UpdatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7544),
                            UserId = 1
                        },
                        new
                        {
                            WalletId = 2,
                            Balance = 0m,
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7546),
                            UpdatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7546),
                            UserId = 2
                        },
                        new
                        {
                            WalletId = 3,
                            Balance = 0m,
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7547),
                            UpdatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7548),
                            UserId = 3
                        },
                        new
                        {
                            WalletId = 4,
                            Balance = 0m,
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7549),
                            UpdatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7549),
                            UserId = 4
                        },
                        new
                        {
                            WalletId = 5,
                            Balance = 0m,
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7550),
                            UpdatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7550),
                            UserId = 5
                        },
                        new
                        {
                            WalletId = 6,
                            Balance = 0m,
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7552),
                            UpdatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7552),
                            UserId = 6
                        });
                });

            modelBuilder.Entity("DAO.Model.JobPost", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobType")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfFloors")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SquareMeters")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobId");

                    b.HasIndex("EmployerId");

                    b.ToTable("JobPosts");
                });

            modelBuilder.Entity("DAO.Model.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("MessageId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DAO.Model.Profiles", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"), 1L, 1);

                    b.Property<string>("Availability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RatingAvg")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("DAO.Model.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ReviewedId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("JobId");

                    b.HasIndex("ReviewedId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("DAO.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Customer"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Employee"
                        },
                        new
                        {
                            RoleId = 4,
                            RoleName = "Staff"
                        });
                });

            modelBuilder.Entity("DAO.Model.TransactionHistory", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WalletId")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.HasIndex("UserId");

                    b.HasIndex("WalletId");

                    b.ToTable("TransactionHistories");
                });

            modelBuilder.Entity("DAO.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7508),
                            DateOfBirth = new DateTime(2002, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "customer@gmail.com",
                            Gender = "Male",
                            Name = "customer",
                            Password = "12345",
                            Phone = "1234567890",
                            RoleId = 2,
                            Status = true
                        },
                        new
                        {
                            UserId = 2,
                            AvatarUrl = "https://example.com/avatar2.jpg",
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7511),
                            DateOfBirth = new DateTime(1990, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "employer@gmail.com",
                            Gender = "Female",
                            Name = "employer",
                            Password = "67890",
                            Phone = "0987654321",
                            RoleId = 3,
                            Status = true
                        },
                        new
                        {
                            UserId = 3,
                            AvatarUrl = "https://example.com/avatar3.jpg",
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7512),
                            DateOfBirth = new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "worker1@gmail.com",
                            Gender = "Male",
                            Name = "worker1",
                            Password = "worker123",
                            Phone = "1122334455",
                            RoleId = 4,
                            Status = true
                        },
                        new
                        {
                            UserId = 4,
                            AvatarUrl = "https://example.com/avatar4.jpg",
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7514),
                            DateOfBirth = new DateTime(1988, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "worker2@gmail.com",
                            Gender = "Female",
                            Name = "worker2",
                            Password = "worker456",
                            Phone = "9988776655",
                            RoleId = 4,
                            Status = false
                        },
                        new
                        {
                            UserId = 5,
                            AvatarUrl = "https://example.com/avatar5.jpg",
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7515),
                            DateOfBirth = new DateTime(1985, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            Gender = "Male",
                            Name = "admin",
                            Password = "admin789",
                            Phone = "1231231234",
                            RoleId = 1,
                            Status = true
                        },
                        new
                        {
                            UserId = 6,
                            AvatarUrl = "https://example.com/avatar6.jpg",
                            CreatedAt = new DateTime(2024, 10, 21, 16, 36, 38, 929, DateTimeKind.Utc).AddTicks(7516),
                            DateOfBirth = new DateTime(2000, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "customer2@gmail.com",
                            Gender = "Female",
                            Name = "customer2",
                            Password = "cust2345",
                            Phone = "4567891230",
                            RoleId = 2,
                            Status = true
                        });
                });

            modelBuilder.Entity("DAO.Model.Application", b =>
                {
                    b.HasOne("DAO.Model.JobPost", "JobPost")
                        .WithMany("Applications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAO.Model.User", "Worker")
                        .WithMany("Applications")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("JobPost");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("DAO.Model.CategoryJobPost", b =>
                {
                    b.HasOne("DAO.Model.Category", "Category")
                        .WithMany("CategoryJobPost")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAO.Model.JobPost", "JobPost")
                        .WithMany("CategoryJobPosts")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("DAO.Model.EWallet", b =>
                {
                    b.HasOne("DAO.Model.User", "User")
                        .WithOne("EWallet")
                        .HasForeignKey("DAO.Model.EWallet", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAO.Model.JobPost", b =>
                {
                    b.HasOne("DAO.Model.User", "Employer")
                        .WithMany("JobPosts")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("DAO.Model.Message", b =>
                {
                    b.HasOne("DAO.Model.User", "Receiver")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAO.Model.User", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("DAO.Model.Profiles", b =>
                {
                    b.HasOne("DAO.Model.User", "User")
                        .WithOne("Profiles")
                        .HasForeignKey("DAO.Model.Profiles", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAO.Model.Review", b =>
                {
                    b.HasOne("DAO.Model.JobPost", "JobPost")
                        .WithMany("Reviews")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAO.Model.User", "Reviewed")
                        .WithMany("ReviewsReceived")
                        .HasForeignKey("ReviewedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAO.Model.User", "Reviewer")
                        .WithMany("ReviewsWritten")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("JobPost");

                    b.Navigation("Reviewed");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("DAO.Model.TransactionHistory", b =>
                {
                    b.HasOne("DAO.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAO.Model.EWallet", "EWallet")
                        .WithMany()
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EWallet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAO.Model.User", b =>
                {
                    b.HasOne("DAO.Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DAO.Model.Category", b =>
                {
                    b.Navigation("CategoryJobPost");
                });

            modelBuilder.Entity("DAO.Model.JobPost", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("CategoryJobPosts");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("DAO.Model.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAO.Model.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("EWallet")
                        .IsRequired();

                    b.Navigation("JobPosts");

                    b.Navigation("MessagesReceived");

                    b.Navigation("MessagesSent");

                    b.Navigation("Profiles")
                        .IsRequired();

                    b.Navigation("ReviewsReceived");

                    b.Navigation("ReviewsWritten");
                });
#pragma warning restore 612, 618
        }
    }
}