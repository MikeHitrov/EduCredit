namespace EduCredit.Data
{
    using EduCredit.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(DatabaseConfiguration.ConnectionString);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<UserCourse> UserCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserCourses)
                .WithOne(uc => uc.User)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<Course>()
                .HasMany(u => u.UserCourses)
                .WithOne(uc => uc.Card)
                .HasForeignKey(u => u.CardId);
        }
    }
}
