namespace QuizApp.Models.Entities;

public record Question
{
    public Guid Id { get; init; }

    public  required string Text { get; init; }

    //options

    public required List<Option> Options { get; set; }
    public required Guid CorrectOption { get; init; }



}
