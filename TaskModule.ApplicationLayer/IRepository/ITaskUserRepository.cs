using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModule.ApplicationLayer.Interface.Common;
using TaskModule.DomainLayer.Response;

namespace TaskModule.ApplicationLayer.Interface
{
    public interface ITaskUserRepository:IGetRepository<TaskUserModelResponse>
    {

    }
}
