using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModule.ApplicationLayer.IRepository;
using TaskModule.DomainLayer.Response;

namespace InfrastructureLayer.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public UserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;

        }
        public async Task<IEnumerable<UserModelResponse>> GetAllAsync()
        {
            return await _dbConnection.QueryAsync<UserModelResponse>("usp_LoadUserDetails", commandType: CommandType.StoredProcedure);
        }

    }
}
