using System.ComponentModel.DataAnnotations.Schema;

public class Education
{
    public Guid Id { get; set; }
    public required int Order { get; set; }
    public required string Location { get; set; }
    public required string Description { get; set; }

    [ForeignKey("User")]
    public required Guid UserId { get; set; }
    public User User { get; set; }
}
