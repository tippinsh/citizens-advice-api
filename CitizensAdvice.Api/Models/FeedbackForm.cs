namespace CitizensAdvice.Api.Models;

public class FeedbackForm
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public int HelpfulRating { get; set; }
    public bool ProblemSolved { get; set; }
    public bool HelpRequired { get; set; }
}