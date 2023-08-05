

namespace bugtracker.Models;

public class Ticket {
    public int TicketId { get; set; }
    public string? TicketName { get; set; }
    public string? TicketDescription { get; set; }
    public string? Priority { get; set; }
    public Byte Status { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime CompletionDate { get; set; }
    public int ProjectId { get; set; }
}