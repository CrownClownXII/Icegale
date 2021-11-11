using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.Base;

namespace UserService.Domain.Entities.Users
{
    public partial class User : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
