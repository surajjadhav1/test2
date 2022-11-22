global using Microsoft.EntityFrameworkCore;

namespace StudentApp.College;

public class CollegeDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; }

    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\METIIT;Database=Student");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>()
                    .ToTable("Course")
                    .Property(c => c.Id)
                    .HasColumnName("CourseId");
        modelBuilder.Entity<Course>()
                    .Property(c => c.Name)
                    .HasColumnName("CourseName");
         modelBuilder.Entity<Student>()
                    .ToTable("Student")
                    .Property(c => c.Id)
                    .HasColumnName("RollNo");               
   }
}