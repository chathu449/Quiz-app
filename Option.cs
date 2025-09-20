namespace QuizApp.Models.Entities;

public record Option
{
    public Guid Id { get; init; }

    public required string Text { get; init; }

    //relationship

    public Guid QuestionId { get; init; }
}
