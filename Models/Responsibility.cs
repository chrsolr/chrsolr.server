using System.ComponentModel.DataAnnotations.Schema;

public class Responsibility
{
    public Guid Id { get; set; }
    public required string Name { get; set; }

    [ForeignKey("Job")]
    public required Guid JobId { get; set; }
    public Job Job { get; set; }
}
