using AutoMapper;
using Schruted.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schruted.DoTasks.Dto
{
    public class DoTaskMapProfile : Profile
    {
        public DoTaskMapProfile()
        {
            CreateMap<DoTask, DoTaskDto>();
            CreateMap<DoTaskDto, DoTask>();
        }
    }
}
