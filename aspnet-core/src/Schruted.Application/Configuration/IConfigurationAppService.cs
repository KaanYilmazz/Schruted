using System.Threading.Tasks;
using Schruted.Configuration.Dto;

namespace Schruted.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
