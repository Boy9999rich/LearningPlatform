using LearningPlatform.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningPlatform.Dal.EntityConfiguration;

public class UserConFiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.HasKey(b => b.UserId);

        builder.Property(b => b.Email)
            .IsRequired(true)
            .HasMaxLength(100);

        builder.Property(b => b.Role)
            .IsRequired(true);

        builder.Property(b => b.Name)
            .IsRequired(true)
            .HasMaxLength(50);
    }
}
