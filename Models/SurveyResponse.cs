namespace Quiz_and_Survey_App.Models;
using System;
using System.Collections.Generic;

public class SurveyResponse
{
    public required int Id { get; set; }

    public required string UserId { get; set; }
    public required AppUser User { get; set; }

    public required int SurveyId { get; set; }
    public required Survey Survey { get; set; }

    public DateTime DateSubmitted { get; set; }

    public ICollection<SurveyAnswer> Answers { get; set; } = new List<SurveyAnswer>();
}
