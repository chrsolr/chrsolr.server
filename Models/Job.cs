using System.ComponentModel.DataAnnotations.Schema;

public class Job
{
    public Guid Id { get; set; }
    public required string CompanyName { get; set; }
    public required string Title { get; set; }
    public required string EndDate { get; set; }
    public required string StartDate { get; set; }
    public required List<Technology> Technologies { get; set; }
    public required List<Responsibility> Responsibilities { get; set; }

    [ForeignKey("User")]
    public required Guid UserId { get; set; }
    public User User { get; set; }
}
