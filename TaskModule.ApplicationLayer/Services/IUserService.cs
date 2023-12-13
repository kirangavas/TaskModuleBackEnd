using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModule.DomainLayer.Response;

namespace TaskModule.ApplicationLayer.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserModelResponse>> GetAllUserList();

    }
}
