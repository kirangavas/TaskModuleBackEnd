using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskModule.ApplicationLayer.Interface.Common
{
    public interface IGetRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
