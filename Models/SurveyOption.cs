namespace Quiz_and_Survey_App.Models;
public class SurveyOption
{
    public int Id { get; set; }
    public required string Text { get; set; }

    public required int SurveyQuestionId { get; set; }
    public required SurveyQuestion SurveyQuestion { get; set; }
}
