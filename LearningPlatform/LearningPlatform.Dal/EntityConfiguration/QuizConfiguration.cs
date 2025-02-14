using LearningPlatform.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningPlatform.Dal.EntityConfiguration;

public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.ToTable("Quiz");

        builder.HasKey(b => b.QuizId);

        builder.Property(b => b.Title)
            .IsRequired(true)
            .HasMaxLength(100);

        builder.Property(b => b.Questions)
            .IsRequired(true);
    }
}
