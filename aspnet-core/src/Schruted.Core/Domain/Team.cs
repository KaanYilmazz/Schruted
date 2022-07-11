using Abp.Domain.Entities;
using Schruted.Authorization.Users;
using Schruted.Enums;
using System.Collections.Generic;

namespace Schruted.Domain
{
    public class Team : Entity<int>
    {
        public string Name { get; set; }
        public List<WorkItem> WorkItems { get; set; }
        public List<User> Users { get; set; }
        public Area Area { get; set; }
    }
}
