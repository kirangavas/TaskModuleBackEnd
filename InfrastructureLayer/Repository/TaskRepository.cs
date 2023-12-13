using Dapper;
using System.Data;
using System.Data.Common;
using TaskModule.ApplicationLayer.Interface;
using TaskModule.DomainLayer.Request;

namespace InfrastructureLayer.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IDbConnection _dbConnection;
        public TaskRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
           
        }
        public async Task<int> AddAsync(TaskModelInput entity)
        {
            // Create a DynamicParameters object to pass parameters to the stored procedure
            var parameters = new DynamicParameters();
            parameters.Add("@taskname", entity.TaskName, DbType.String);
            parameters.Add("@taskdescription", entity.TaskDescription, DbType.String);
            parameters.Add("@assignto", entity.AssignTo, DbType.Int32);

            // Execute the stored procedure using Dapper
            var result = await _dbConnection.ExecuteAsync("usp_AddTaskProcedure", parameters, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}