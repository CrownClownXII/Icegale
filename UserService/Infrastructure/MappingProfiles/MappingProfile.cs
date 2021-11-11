using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Application.Commands.CreateUser;
using UserService.Application.Dtos;
using UserService.Domain.Entities.Users;

namespace UserService.Infrastructure.MappingProfiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserRequestDto, CreateUserCommand>();
            CreateMap<User, UserDto>();
        }
    }
}
