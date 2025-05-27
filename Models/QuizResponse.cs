namespace Quiz_and_Survey_App.Models;
using System;
using System.Collections.Generic;

public class QuizResponse
{
    public int Id { get; set; }

    public string UserId { get; set; }
    public AppUser User { get; set; }

    public int QuizId { get; set; }
    public Quiz Quiz { get; set; }

    public DateTime DateSubmitted { get; set; }

    public ICollection<QuizAnswer> Answers { get; set; } = new List<QuizAnswer>();
}
