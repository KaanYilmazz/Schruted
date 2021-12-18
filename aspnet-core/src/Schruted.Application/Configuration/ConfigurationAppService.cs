using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Schruted.Configuration.Dto;

namespace Schruted.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SchrutedAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
