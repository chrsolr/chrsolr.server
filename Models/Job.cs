public class Job
{
    public Guid Id { get; set; }
    public required string CompanyName { get; set; }
    public required string Title { get; set; }
    public required DateOnly EndDate { get; set; }
    public required DateOnly StartDate { get; set; }
    public required List<Technology> Technologies { get; set; }
    public required List<Responsibility> Responsibilities { get; set; }
}