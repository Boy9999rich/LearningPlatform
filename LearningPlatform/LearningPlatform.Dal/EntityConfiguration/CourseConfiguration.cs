using LearningPlatform.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningPlatform.Dal.EntityConfiguration;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Course");

        builder.HasKey(b => b.CourseId);

        builder.Property(b => b.Name)
            .IsRequired(true)
            .HasMaxLength(50);

        builder.Property(b => b.InstructorId)
            .IsRequired(true);

        builder.HasMany(b => b.Lessons)
            .WithOne(b => b.Course)
            .HasForeignKey(b => b.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(b => b.Enrollments)
            .WithOne(b => b.Course)
            .HasForeignKey(b => b.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(c => c.Instructor)
            .WithMany(c => c.Courses)
            .HasForeignKey(c => c.InstructorId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
