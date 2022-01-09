using Abp.Application.Services;
using Abp.Authorization;
using Schruted.Domain;
using Schruted.Authorization;
using Schruted.DoTasks.Dto;
using Abp.Domain.Repositories;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.Collections.Generic;
using System.Linq;

namespace Schruted.DoTasks
{
    [AbpAuthorize(PermissionNames.Pages_PersonalTask)]

    public class DoTaskAppService : ApplicationService, IDoTaskAppService
    {
        private readonly IRepository<DoTask, int> _repository;
        public DoTaskAppService(IRepository<DoTask,int> repository)
        {
            _repository = repository;
        }

        public async Task <DoTaskDto> CreateAsync(DoTaskDto input)
        {            
          var response = await _repository.InsertAsync(ObjectMapper.Map<DoTask>(input));
          return ObjectMapper.Map<DoTaskDto>(response);
        }

        public async Task DeleteAsync(EntityDto<int> input)
        {
            var item = await _repository.GetAsync(input.Id);
            await  _repository.DeleteAsync(item);
        }

        public async Task <List<DoTaskDto>> GetAllAsync()
        {
            List<DoTaskDto> response = new List<DoTaskDto>();
            try
            {
                var Items = await _repository.GetAllListAsync();
                return ObjectMapper.Map(Items,response); 
            }
            catch (System.Exception ex)
            {

                Logger.Error(ex.Message);
                return null;
            }
            
        }

        public async Task<DoTaskDto> GetAsync(EntityDto<int> input)
        {
            var response = await _repository.GetAsync(input.Id);
            return  ObjectMapper.Map<DoTaskDto>(response);
        }

        public async Task<DoTaskDto> UpdateAsync(DoTaskDto input)
        {
            var response = await _repository.UpdateAsync(ObjectMapper.Map<DoTask>(input));
            return ObjectMapper.Map<DoTaskDto>(response);
        }

    }
}
