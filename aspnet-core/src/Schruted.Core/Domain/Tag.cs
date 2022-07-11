using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schruted.Domain
{
    public class Tag : Entity<int>
    {
        public string Name { get; set; }
        public WorkItem WorkItem { get; set; }

    }
}
