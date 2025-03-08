using Blazor.WASM.Models;

namespace Blazor.WASM.Identity
{
    public interface IAccountManagement
    {
        Task<AuthResult> LoginAsync(LoginModel _credentials);
        Task<AuthResult> RegisterAsync(string email , string password);
        Task LogoutAsync();

    }
}
