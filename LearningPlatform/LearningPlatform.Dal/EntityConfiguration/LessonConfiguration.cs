using LearningPlatform.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningPlatform.Dal.EntityConfiguration;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.ToTable("Lesson");

        builder.HasKey(b => b.LessonId);

        builder.Property(b => b.Title)
            .IsRequired(true)
            .HasMaxLength(50);

        builder.HasMany(b => b.Quizs)
            .WithOne(b => b.Lesson)
            .HasForeignKey(b => b.LessonId);
    }
}
