using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Entities;

public class Answer
{
    [Key]
    public int Id { get; set; }
    public string Text { get; set; }
    public string User { get; set; }

    [ForeignKey("Question")]
    public int QuestionId { get; set; }
    public Question? Question { get; set; }
}

public class CreateAnswer
{
    [Required]
    public string Text { get; set; }
    [Required]
    public string User { get; set; }
}

public class UpdateAnswer
{
    [Required]
    public string Text { get; set; }
    [Required]
    public string User { get; set; }
    public int? QuestionId { get; set; }
}