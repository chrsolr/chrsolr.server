using System.ComponentModel.DataAnnotations.Schema;

public class Technology
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    
    [ForeignKey("Job")]
    public Guid JobId { get; set; }
    public Job Job { get; set; }
}