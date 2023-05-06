namespace Coworking.Service.Interfaces
{
    public interface IAuthService
    {
        ValueTask<string> GenerateTokenAsync(string email, string password);
    }
}
