using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModule.ApplicationLayer.Interface;
using TaskModule.DomainLayer.Request;
using TaskModule.DomainLayer.Response;

namespace TaskModule.ApplicationLayer.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskUserRepository _taskUserRepository;

        public TaskService(ITaskRepository taskRepository, ITaskUserRepository taskUserRepository)
        {
            _taskRepository = taskRepository;
            _taskUserRepository = taskUserRepository;
            
        }

        public async Task<int> AddTaskAsync(TaskModelInput taskModelInput)
        {
            return await _taskRepository.AddAsync(taskModelInput);
        }


        public async Task<IEnumerable<TaskUserModelResponse>> GetAllTaskUserListAsync()
        {
            return await _taskUserRepository.GetAllAsync();
        }
    }
}
