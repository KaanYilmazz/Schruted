using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schruted.Domain
{
    public class DoTask: Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxPoint { get; set; }

    }
}
