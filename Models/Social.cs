using System.ComponentModel.DataAnnotations.Schema;

public class Social
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Url { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey("User")]
    public required Guid UserId { get; set; }
    public required User User { get; set; }
}
