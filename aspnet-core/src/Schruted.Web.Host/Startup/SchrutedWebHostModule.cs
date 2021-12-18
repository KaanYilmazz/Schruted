using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Schruted.Configuration;

namespace Schruted.Web.Host.Startup
{
    [DependsOn(
       typeof(SchrutedWebCoreModule))]
    public class SchrutedWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SchrutedWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchrutedWebHostModule).GetAssembly());
        }
    }
}
