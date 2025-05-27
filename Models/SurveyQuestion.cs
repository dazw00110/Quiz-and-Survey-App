namespace Quiz_and_Survey_App.Models;
using System.Collections.Generic;

public class SurveyQuestion
{
    public int Id { get; set; }
    public required string Text { get; set; }
    public required QuestionType Type { get; set; }

    public required int SurveyId { get; set; }
    public required Survey Survey { get; set; }

    public ICollection<SurveyOption> Options { get; set; } = new List<SurveyOption>();
}
