namespace Quiz_and_Survey_App.Models;
public class QuizAnswer
{
    public int Id { get; set; }

    public required int QuizResponseId { get; set; }
    public required QuizResponse QuizResponse { get; set; }

    public required int QuizQuestionId { get; set; }
    public required QuizQuestion QuizQuestion { get; set; }

    public required string AnswerText { get; set; }
}
