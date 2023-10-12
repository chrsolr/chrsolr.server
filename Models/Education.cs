using System.ComponentModel.DataAnnotations.Schema;

public class Education
{
    public Guid Id { get; set; }
    public required int Order { get; set; }
    public required string Location { get; set; }
    public required string Description { get; set; }

    [ForeignKey("About")]
    public Guid AboutId { get; set; }
    public About About { get; set; }
}
