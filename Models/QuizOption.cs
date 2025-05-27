namespace Quiz_and_Survey_App.Models;
public class QuizOption
{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool IsCorrect { get; set; }

    public int QuizQuestionId { get; set; }
    public QuizQuestion QuizQuestion { get; set; }
}
