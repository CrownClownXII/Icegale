using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UserService.Application.Dtos;
using UserService.Application.Services.Users;

namespace UserService.Application.Commands.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly IAppUserService _userService;

        public CreateUserHandler(IAppUserService userService)
        {
            _userService = userService;
        }

        public Task<UserDto> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            return _userService.CreateUserAsync(command);
        }
    }
}
