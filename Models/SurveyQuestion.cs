namespace Quiz_and_Survey_App.Models;
using System.Collections.Generic;

public class SurveyQuestion
{
    public int Id { get; set; }
    public string Text { get; set; }
    public QuestionType Type { get; set; }

    public int SurveyId { get; set; }
    public Survey Survey { get; set; }

    public ICollection<SurveyOption> Options { get; set; } = new List<SurveyOption>();
}
