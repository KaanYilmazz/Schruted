using Abp.Domain.Entities;

namespace Schruted.Domain
{
    public class WorkFile : Entity<int>
    {
        public string Name { get; set; }
        public string FileRoad { get; set; }
        public WorkItem WorkItem { get; set; }

    }
}
