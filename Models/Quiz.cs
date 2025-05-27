namespace Quiz_and_Survey_App.Models;
using System.Collections.Generic;

public class Quiz
{
    public int Id { get; set; }
    public string Title { get; set; }

    public string UserId { get; set; }
    public AppUser User { get; set; }

    public ICollection<QuizQuestion> Questions { get; set; } = new List<QuizQuestion>();
}

