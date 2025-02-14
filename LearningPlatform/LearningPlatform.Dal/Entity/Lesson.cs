namespace LearningPlatform.Dal.Entity;

public class Lesson
{
    public long LessonId { get; set; }
    public string Title { get; set; }
    public string VideoUrl { get; set; }
    public long CourseId { get; set; }
    public Course Course { get; set; }
    public ICollection<Quiz> Quizs { get; set; }
}
