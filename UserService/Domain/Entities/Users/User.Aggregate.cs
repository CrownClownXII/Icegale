using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.Base.Abstract;
using UserService.Domain.Events.Users;

namespace UserService.Domain.Entities.Users
{
    public partial class User : IAggregateRoot
    {
        public User(string email, string firstName, string lastName, string login, string password)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Login = login;
            CreatedAt = DateTime.Now;
            Password = password;

            AddDomainEvent(new UserCreatedEvent(email, password));
        }
    }
}
