public class JobDTO
{
    public required string CompanyName { get; set; }
    public required string Title { get; set; }
    public required string EndDate { get; set; }
    public required string StartDate { get; set; }
    public required string[] Technologies { get; set; }
    public required string[] Responsibilities { get; set; }
}
