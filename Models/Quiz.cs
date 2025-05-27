namespace Quiz_and_Survey_App.Models;
using System.Collections.Generic;

public class Quiz
{
    public int Id { get; set; }
    public required string Title { get; set; }

    public required string UserId { get; set; }
    public required AppUser User { get; set; }

    public ICollection<QuizQuestion> Questions { get; set; } = new List<QuizQuestion>();
}

