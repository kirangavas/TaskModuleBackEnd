using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModule.ApplicationLayer.Interface;
using TaskModule.ApplicationLayer.IRepository;
using TaskModule.DomainLayer.Response;

namespace TaskModule.ApplicationLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<UserModelResponse>> GetAllUserList()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}
