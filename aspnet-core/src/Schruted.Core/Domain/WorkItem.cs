using Abp.Domain.Entities;
using Schruted.Authorization.Users;
using Schruted.Enums;
using System;
using System.Collections.Generic;

namespace Schruted.Domain
{
   public class WorkItem : Entity<int>
    {
        public string Title { get; set; }
        public WorkType WorkType { get; set; }
        public int Code { get; set; }
        public double Effort { get; set; }
        public int Priority { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime PlannedEndTime { get; set; }
        public Project Project { get; set; }
        public string Branch { get; set; }
        public List<Comment> Comments { get; set; }
        public List<WorkItem> ConnectedItems { get; set; }
        public User AssignedUser { get; set; }
        public Team AssignedTeam { get; set; }
        public List<WorkFile> Files { get; set; }
        public List<WorkLog> WorkLogs { get; set; }
    }
}
