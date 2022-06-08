using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Schruted.Domain;
using Schruted.DoTasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schruted.DoTasks
{
    public interface IDoTaskAppService
    {
        public  Task<DoTaskDto> CreateAsync(DoTaskDto input);
        public  Task DeleteAsync(EntityDto<int> input);
        public Task<DoTaskDto> UpdateAsync(DoTaskDto input);
        public Task<DoTaskDto> GetAsync(EntityDto<int> input);
        public Task<List<DoTaskDto>> GetAllAsync();
    }
}
