namespace Quiz_and_Survey_App.Models;
public class SurveyAnswer
{
    public int Id { get; set; }

    public int SurveyResponseId { get; set; }
    public SurveyResponse SurveyResponse { get; set; }

    public int SurveyQuestionId { get; set; }
    public SurveyQuestion SurveyQuestion { get; set; }

    public string AnswerText { get; set; }
}
