using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.Base;

namespace UserService.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
        IRepository<T> Repository<T>() where T : BaseEntity;
    }
}
