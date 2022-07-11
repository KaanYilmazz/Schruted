using Abp.Domain.Entities;
using Schruted.Authorization.Users;
using System;

namespace Schruted.Domain
{
    public class WorkLog : Entity
    {
        public User CreatorUser { get; set; }
        public DateTime CreationTime { get; set; }
        public string Log { get; set; }

        public WorkItem WorkItem { get; set; }
    }
}
