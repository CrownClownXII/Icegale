using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Domain.Events.Users
{
    public class UserCreatedEvent : INotification
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public UserCreatedEvent(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
