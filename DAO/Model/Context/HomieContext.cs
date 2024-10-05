using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model.Context
{
    public class HomieContext : DbContext
    {
        public HomieContext() { }

        public HomieContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<EWallet> EWallets { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryJobPost> CategoryJobPosts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationships can be defined here if needed (optional)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            // JobPost and User: One-to-Many
            modelBuilder.Entity<JobPost>()
                .HasOne(j => j.Employer)
                .WithMany(u => u.JobPosts)
                .HasForeignKey(j => j.EmployerId);

            // Application and User: One-to-Many
            modelBuilder.Entity<Application>()
                .HasOne(a => a.Worker)
                .WithMany(u => u.Applications)
                .HasForeignKey(a => a.WorkerId);

            // Reviews: One-to-Many for Reviewer and Reviewed
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewer)
                .WithMany(u => u.ReviewsWritten)
                .HasForeignKey(r => r.ReviewerId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewed)
                .WithMany(u => u.ReviewsReceived)
                .HasForeignKey(r => r.ReviewedId);

            // Messages: One-to-Many for Sender and Receiver
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.MessagesSent)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);  // Prevent cascading delete

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.MessagesReceived)
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            // Application-Worker (User)
            modelBuilder.Entity<Application>()
                .HasOne(a => a.Worker)
                .WithMany(u => u.Applications)
                .HasForeignKey(a => a.WorkerId)
                .OnDelete(DeleteBehavior.Restrict);  // Prevent cascade delete

            // Application-JobPost
            modelBuilder.Entity<Application>()
                .HasOne(a => a.JobPost)
                .WithMany(j => j.Applications)
                .HasForeignKey(a => a.JobId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewer)
                .WithMany(u => u.ReviewsWritten)  // A user can write many reviews
                .HasForeignKey(r => r.ReviewerId)
                .OnDelete(DeleteBehavior.Restrict);  // Prevent cascading delete

            // Review-User (Reviewed)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewed)
                .WithMany(u => u.ReviewsReceived)  // A user can receive many reviews
                .HasForeignKey(r => r.ReviewedId)
                .OnDelete(DeleteBehavior.Restrict);  // Prevent cascading delete

            // Review-JobPost (if required)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.JobPost)
                .WithMany(j => j.Reviews)  // Assuming JobPost has a Reviews collection
                .HasForeignKey(r => r.JobId);

            // One-to-One relationship between User and EWallet
            modelBuilder.Entity<User>()
                .HasOne(u => u.EWallet)
                .WithOne(w => w.User)
                .HasForeignKey<EWallet>(w => w.UserId);

            // TransactionHistory to User (One-to-Many)
            modelBuilder.Entity<TransactionHistory>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict);  // Ngăn chặn xóa cascade

            // TransactionHistory to EWallet (One-to-Many)
            modelBuilder.Entity<TransactionHistory>()
                .HasOne(t => t.EWallet)
                .WithMany()
                .HasForeignKey(t => t.WalletId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CategoryJobPost>()
        .HasKey(jc => new { jc.JobPostId, jc.CategoryId });

            modelBuilder.Entity<CategoryJobPost>()
                .HasOne(jc => jc.JobPost)
                .WithMany(jp => jp.CategoryJobPosts)
                .HasForeignKey(jc => jc.JobPostId);

            modelBuilder.Entity<CategoryJobPost>()
                .HasOne(jc => jc.Category)
                .WithMany(c => c.CategoryJobPost)
                .HasForeignKey(jc => jc.CategoryId);

            base.OnModelCreating(modelBuilder);
            HomieContextSeeder.Seed(modelBuilder);
        }
    }
}

