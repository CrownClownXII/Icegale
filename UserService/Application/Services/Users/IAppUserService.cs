using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Application.Commands.CreateUser;
using UserService.Application.Dtos;
using UserService.Domain.Entities.Users;

namespace UserService.Application.Services.Users
{
    public interface IAppUserService
    {
        Task<UserDto> CreateUserAsync(CreateUserCommand command);
    }
}
