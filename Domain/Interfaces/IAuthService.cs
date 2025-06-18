using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Domain.Interfaces;

public interface IAuthService
{
    Task<IdentityResult> RegisterAsync(User user, string password);
    Task<string> LoginAsync(string email, string password);
}