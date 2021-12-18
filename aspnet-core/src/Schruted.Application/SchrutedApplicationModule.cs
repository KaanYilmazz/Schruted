using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Schruted.Authorization;

namespace Schruted
{
    [DependsOn(
        typeof(SchrutedCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SchrutedApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SchrutedAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SchrutedApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
