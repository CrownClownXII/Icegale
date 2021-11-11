using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.Repositories;

namespace UserService.Application.Services
{
    public class BaseService
    {
        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected readonly IUnitOfWork _unitOfWork;
    }
}
