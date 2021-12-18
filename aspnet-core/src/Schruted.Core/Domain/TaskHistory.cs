using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schruted.Domain
{
    public class TaskHistory:Entity<int>
    {
        public DoTask DoTasks { get; set; }
        public DateTime TaskDate { get; set; }
        public int Point { get; set; }
    }
}
