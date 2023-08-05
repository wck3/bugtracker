

namespace bugtracker.Models;

public class Project {
    public int ProjectId { get; set; }
    public string? ProjectName { get; set; }
    public string? ProjectDescription { get; set; }
    public Byte Status { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime CompletionDate { get; set; }
}