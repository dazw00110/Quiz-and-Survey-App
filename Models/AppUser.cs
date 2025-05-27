namespace Quiz_and_Survey_App.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

public class AppUser : IdentityUser
{
    public ICollection<Quiz> CreatedQuizzes { get; set; } = new List<Quiz>();
    public ICollection<Survey> CreatedSurveys { get; set; } = new List<Survey>();

    public ICollection<QuizResponse> QuizResponses { get; set; } = new List<QuizResponse>();
    public ICollection<SurveyResponse> SurveyResponses { get; set; } = new List<SurveyResponse>();
}
