namespace Quiz_and_Survey_App.Models;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;

public enum QuestionType
{
    Open,
    SingleChoice,
    MultipleChoice
}

public class QuizQuestion
{
    public int Id { get; set; }
    public string Text { get; set; }
    public QuestionType Type { get; set; }

    public int QuizId { get; set; }
    public Quiz Quiz { get; set; }

    public ICollection<QuizOption> Options { get; set; } = new List<QuizOption>();
}
