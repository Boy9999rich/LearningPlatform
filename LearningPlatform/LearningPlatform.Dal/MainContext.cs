using LearningPlatform.Dal.Entity;
using LearningPlatform.Dal.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.Dal;

public class MainContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Quiz> Quizs { get; set; }
    public DbSet<User> Users { get; set; }

    public MainContext(DbContextOptions<MainContext> options)
       : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CourseConfiguration());
        modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());
        modelBuilder.ApplyConfiguration(new LessonConfiguration());
        modelBuilder.ApplyConfiguration(new QuizConfiguration());
        modelBuilder.ApplyConfiguration(new UserConFiguration());
    }
}
