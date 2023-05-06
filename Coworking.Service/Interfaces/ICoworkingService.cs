using Coworking.Service.DTOs;

namespace Coworking.Service.Interfaces
{
    public interface ICoworkingService
    {
        ValueTask<CoworkingResultDto> CreateAsync(CoworkingCreationDto dto);
        ValueTask<CoworkingResultDto> UpdateAsync(CoworkingUpdateDto dto);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<CoworkingResultDto> GetByIdAsync(long id);
        ValueTask<IEnumerable<CoworkingResultDto>> GetAllAsync();
    }
}
