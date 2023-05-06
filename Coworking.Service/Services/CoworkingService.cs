using Coworking.Service.DTOs;
using Coworking.Service.Interfaces;

namespace Coworking.Service.Services
{
    public class CoworkingService : ICoworkingService
    {
        public ValueTask<CoworkingResultDto> CreateAsync(CoworkingCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<CoworkingResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<CoworkingResultDto> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CoworkingResultDto> UpdateAsync(CoworkingUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
