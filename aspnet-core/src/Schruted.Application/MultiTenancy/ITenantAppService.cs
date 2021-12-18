using Abp.Application.Services;
using Schruted.MultiTenancy.Dto;

namespace Schruted.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

