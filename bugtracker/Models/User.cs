

namespace bugtracker.Models;

public class User {
    public int UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Bio { get; set; }
    public string? password { get; set; }
}