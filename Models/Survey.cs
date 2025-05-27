namespace Quiz_and_Survey_App.Models;
using System.Collections.Generic;

public class Survey
{
    public int Id { get; set; }
    public required string Title { get; set; }

    public required string UserId { get; set; }
    public required AppUser User { get; set; }

    public ICollection<SurveyQuestion> Questions { get; set; } = new List<SurveyQuestion>();
}
