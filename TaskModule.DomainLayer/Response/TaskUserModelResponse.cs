using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskModule.DomainLayer.Response
{
    public class TaskUserModelResponse
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string UserFirstNameLastName { get; set; }
    }
}
