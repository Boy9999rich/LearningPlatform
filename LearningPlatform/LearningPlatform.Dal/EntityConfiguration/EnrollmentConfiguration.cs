using LearningPlatform.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningPlatform.Dal.EntityConfiguration;

public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder.ToTable("Enrolment");

        builder.HasKey(b => b.EnrollmentId);

        builder.Property(e => e.EnrollmentDate)
            .IsRequired();

        builder.HasOne(b => b.User)
            .WithMany(b => b.Enrollments)
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
