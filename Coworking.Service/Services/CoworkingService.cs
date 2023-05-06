using AutoMapper;
using Coworking.Data.IRepositories;
using Coworking.Domain.Entities;
using Coworking.Service.DTOs;
using Coworking.Service.Exceptions;
using Coworking.Service.Interfaces;

namespace Coworking.Service.Services
{
    public class CoworkingService : ICoworkingService
    {
        private readonly IRepository<Coworkingg> repository;
        private readonly IMapper mapper;

        public CoworkingService(IMapper mapper, IRepository<Coworkingg> repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async ValueTask<CoworkingResultDto> CreateAsync(CoworkingCreationDto dto)
        {
            var example = mapper.Map<Coworkingg>(dto);
            example = await this.repository.InsertAsync(example);
            return mapper.Map<CoworkingResultDto>(example);
        }

        public async ValueTask<bool> DeleteAsync(long id)
        {
            var example = await this.repository.GetAsync(id);

            if (example != null) 
            {
                await this.repository.DeleteAsync(example);
                return true;
            }
            return false;
            throw new CoworkingException(404,"Not found...");
        }

        public async ValueTask<IEnumerable<CoworkingResultDto>> GetAllAsync()
        {
            var examples = await this.repository.GetAllAsync();
            return mapper.Map<IEnumerable<CoworkingResultDto>>(examples);
        }

        public async ValueTask<CoworkingResultDto> GetByIdAsync(long id)
        {
            var first = await this.repository.GetAsync(id);
            if(first == null)
                throw new CoworkingException(404,$"Could not find {id}");

            return mapper.Map<CoworkingResultDto>(first);
        }

        public async ValueTask<CoworkingResultDto> UpdateAsync(CoworkingUpdateDto dto)
        {
            var exaple = await this.repository.GetAsync(dto.Id);
            if(exaple == null)
            {
                return null;
                throw new CoworkingException(404, "Not found...");
            }

            mapper.Map(dto, exaple);
            exaple = await this.repository.UpdateAsync(exaple);
            return mapper.Map<CoworkingResultDto>(exaple);
        }
    }
}
