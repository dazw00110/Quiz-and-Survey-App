namespace Quiz_and_Survey_App.Models;
public class SurveyOption
{
    public int Id { get; set; }
    public string Text { get; set; }

    public int SurveyQuestionId { get; set; }
    public SurveyQuestion SurveyQuestion { get; set; }
}
