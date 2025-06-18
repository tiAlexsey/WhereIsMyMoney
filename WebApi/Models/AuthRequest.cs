namespace WebApi.Models;

public record AuthRequest
{
    public required string Email { get; set; }
    public required string Password { get; set; }
}