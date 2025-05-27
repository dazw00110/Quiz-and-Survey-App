namespace Quiz_and_Survey_App.Models;
using System;
using System.Collections.Generic;

public class QuizResponse
{
    public int Id { get; set; }

    public required string UserId { get; set; }
    public required AppUser User { get; set; }

    public required int QuizId { get; set; }
    public required Quiz Quiz { get; set; }

    public DateTime DateSubmitted { get; set; }

    public ICollection<QuizAnswer> Answers { get; set; } = new List<QuizAnswer>();
}
