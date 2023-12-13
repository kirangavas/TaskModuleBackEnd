namespace TaskModule.DomainLayer.Request
{
    public class TaskModelInput
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int AssignTo { get; set; }
    }
}