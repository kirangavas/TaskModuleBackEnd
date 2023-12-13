using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModule.DomainLayer.Request;
using TaskModule.DomainLayer.Response;

namespace TaskModule.ApplicationLayer.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskUserModelResponse>> GetAllTaskUserListAsync();
        Task<int> AddTaskAsync(TaskModelInput taskModelInput);

    }
}
