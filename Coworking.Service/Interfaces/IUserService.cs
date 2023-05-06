using Coworking.Service.DTOs;

namespace Coworking.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserResultDto> CreateAsync(UserCreationDto dto);
        ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<UserResultDto> GetByIdAsync(long id);
        ValueTask<IEnumerable<UserResultDto>> GetAllAsync();
    }
}
