﻿using AutoMapper;
using Coworking.Data.IRepositories;
using Coworking.Domain.Entities;
using Coworking.Service.DTOs;
using Coworking.Service.Exceptions;
using Coworking.Service.Interfaces;

namespace Coworking.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;
        private readonly IMapper mapper;
        public UserService(IRepository<User> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<UserResultDto> CheckUserAsync(string email, string password = null)
        {
            var user = await this.repository.CheckingAsync(user => user.Email == email);

            if (user == null)
            {
                throw new CoworkingException(404, "User not found...");
            }

            return this.mapper.Map<UserResultDto>(user);
        }

        public async ValueTask<UserResultDto> CreateAsync(UserCreationDto dto)
        {
            var existingUser = await this.repository.CheckingAsync(user => user.Email == dto.Email);
            if (existingUser != null)
            {
                throw new CoworkingException(400, "User with this email already exists...");
            }

            var mappedUser = this.mapper.Map<User>(dto);
            mappedUser = await this.repository.InsertAsync(mappedUser);
            await this.repository.SaveChangesAsync();
            return this.mapper.Map<UserResultDto>(mappedUser);
        }


        public async ValueTask<bool> DeleteAsync(long id)
        {
            var deletedUser = await this.repository.GetAsync(id);
            if (deletedUser == null)
            {
                return false;
                throw new CoworkingException(400, "User not found...");
            }
                await repository.DeleteAsync(deletedUser);
                await repository.SaveChangesAsync();
                return true;
        }

        public async ValueTask<IEnumerable<UserResultDto>> GetAllAsync()
        {
            var users = await this.repository.GetAllAsync();
            return mapper.Map<IEnumerable<UserResultDto>>(users);
        }

        public async ValueTask<UserResultDto> GetByIdAsync(long id)
        {
            var user = await this.repository.GetAsync(id);

            if (user != null)
            {
                return mapper.Map<UserResultDto>(user);
            }
            throw new CoworkingException(400, "User not found...");
        }

        public async ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto)
        {
            var user = await this.repository.GetAsync(dto.Id);

            if (user != null)
            {
                mapper.Map(dto, user);
                user = await repository.UpdateAsync(user);
                return mapper.Map<UserResultDto>(user);
            }

            throw new CoworkingException(404, "User not found...");
        }
    }
}
