using Microsoft.AspNetCore.Mvc;
using TaskModule.ApplicationLayer.Services;
using TaskModule.DomainLayer.Request;
using TaskModule.DomainLayer.Response;

namespace TaskModule.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TaskModuleController : ControllerBase
    {
        
        private readonly ITaskService _taskService;

        public TaskModuleController(ITaskService taskService)
        {
            this._taskService = taskService; 
        }

        [HttpGet(Name = "GetTaskUsers")]
        public async Task<ActionResult<IEnumerable<TaskUserModelResponse>>> Get()
        {
            var taskUserList = await _taskService.GetAllTaskUserListAsync();

            return Ok(taskUserList);
        }


     
        [HttpPost("AddTask")]
        public async Task<ActionResult<int>> PostAsync([FromBody] TaskModelInput taskModelInput)
        {
            try
            {
                var result = await _taskService.AddTaskAsync(taskModelInput);
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it according to your needs
                return StatusCode(500,ex.ToString());
            }
        }



    }
}