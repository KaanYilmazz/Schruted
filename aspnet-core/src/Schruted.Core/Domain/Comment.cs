using Abp.Domain.Entities;
using Schruted.Authorization.Users;
using System;

namespace Schruted.Domain
{
    public class Comment : Entity<int>
    {
        public string Content { get; set; }
        public User User  { get; set; }
        public WorkItem WorkItem  { get; set; }

        public DateTime CommentDate { get; set; }
    }
}
