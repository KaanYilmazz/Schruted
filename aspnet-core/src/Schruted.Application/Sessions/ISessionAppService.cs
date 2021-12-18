using System.Threading.Tasks;
using Abp.Application.Services;
using Schruted.Sessions.Dto;

namespace Schruted.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
