using Abp.Application.Services.Dto;

namespace Schruted.DoTasks.Dto
{
    public class DoTaskDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxPoint { get; set; }
    }
}
