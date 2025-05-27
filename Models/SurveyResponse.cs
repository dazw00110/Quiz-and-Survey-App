namespace Quiz_and_Survey_App.Models;
using System;
using System.Collections.Generic;

public class SurveyResponse
{
    public int Id { get; set; }

    public string UserId { get; set; }
    public AppUser User { get; set; }

    public int SurveyId { get; set; }
    public Survey Survey { get; set; }

    public DateTime DateSubmitted { get; set; }

    public ICollection<SurveyAnswer> Answers { get; set; } = new List<SurveyAnswer>();
}
