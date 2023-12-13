using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModule.ApplicationLayer.Interface;
using TaskModule.DomainLayer.Response;

namespace InfrastructureLayer.Repository
{

    public class TaskUserRepository : ITaskUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public TaskUserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<TaskUserModelResponse>> GetAllAsync()
        {
            return await _dbConnection.QueryAsync<TaskUserModelResponse>("usp_LoadTaskUserDetails", commandType: CommandType.StoredProcedure);
        }
    }
}
