namespace Quiz_and_Survey_App.Models;
public class SurveyAnswer
{
    public required int Id { get; set; }

    public int SurveyResponseId { get; set; }
    public required SurveyResponse SurveyResponse { get; set; }

    public required int SurveyQuestionId { get; set; }
    public required SurveyQuestion SurveyQuestion { get; set; }

    public required string AnswerText { get; set; }
}
