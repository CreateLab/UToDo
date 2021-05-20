using System.Security.Principal;

namespace UToDO.DAL.Entities
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EstimatedTime { get; set;}
        public string ElapsedTime { get; set; }
    }
}