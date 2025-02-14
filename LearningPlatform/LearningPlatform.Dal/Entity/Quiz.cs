namespace LearningPlatform.Dal.Entity;

public class Quiz
{
    public long QuizId { get; set; }
    public string Title { get; set; }
    public string Questions { get; set; }
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }
}

