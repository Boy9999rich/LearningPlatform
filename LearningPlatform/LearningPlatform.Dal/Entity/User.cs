namespace LearningPlatform.Dal.Entity;

public class User
{
    public long UserId { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string Name { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
    public ICollection<Course> Courses { get; set; }
}
