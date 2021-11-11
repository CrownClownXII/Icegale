
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Application.Commands.CreateUser;
using UserService.Application.Dtos;
using UserService.Domain.Entities.Users;
using UserService.Domain.Repositories;

namespace UserService.Application.Services.Users
{
    public class AppUserService : BaseService, IAppUserService
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;

        public AppUserService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork)
        {
            _repository = unitOfWork.Repository<User>();
            _mapper = mapper;
        }

        public async Task<UserDto> CreateUserAsync(CreateUserCommand command)
        {
            await ValidateUserAsync(command);

            var user = new User(
                command.Email,
                command.FirstName,
                command.LastName,
                command.Login,
                command.Password
            );

            _repository.Add(user);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<UserDto>(user);
        }

        private async Task ValidateUserAsync(CreateUserCommand command)
        {
            var isUserWithEmailExist = await _repository.ExsistAsync(c => c.Email == command.Email);

            if (isUserWithEmailExist)
            {
                throw new Exception("Email already connected with active account.");
            }

            var isUserWithLoginExist = await _repository.ExsistAsync(c => c.Login == command.Login);

            if (isUserWithEmailExist)
            {
                throw new Exception("Login already connected with active account.");
            }
        }
    }
}
