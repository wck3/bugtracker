

namespace bugtracker.Models;

public class Comment {
    public int CommentId { get; set; }
    public string? CommentString { get; set; }
    public DateTime CreationDate { get; set; }
    public int UserId { get; set; }
    public int TicketId { get; set; }
}