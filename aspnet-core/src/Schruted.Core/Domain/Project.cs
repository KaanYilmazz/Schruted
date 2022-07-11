using Abp.Domain.Entities;

namespace Schruted.Domain
{
    public class Project : Entity<int>
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Descrption { get; set; }

        
    }
}
