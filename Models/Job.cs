public class Job
{
    public Guid Id { get; set; }
    public required string CompanyName { get; set; }
    public required string Title { get; set; }
    public required DateTime EndDate { get; set; }
    public required DateTime StartDate { get; set; }
    public required List<Technology> Technologies { get; set; }
    public required List<Responsibility> Responsibilities { get; set; }
}