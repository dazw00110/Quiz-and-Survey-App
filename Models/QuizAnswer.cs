namespace Quiz_and_Survey_App.Models;
public class QuizAnswer
{
    public int Id { get; set; }

    public int QuizResponseId { get; set; }
    public QuizResponse QuizResponse { get; set; }

    public int QuizQuestionId { get; set; }
    public QuizQuestion QuizQuestion { get; set; }

    public string AnswerText { get; set; }
}
