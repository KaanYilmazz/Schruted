using Abp.Domain.Entities;

namespace Schruted.Domain
{
    public class DoTask: Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxPoint { get; set; }

    }
}
