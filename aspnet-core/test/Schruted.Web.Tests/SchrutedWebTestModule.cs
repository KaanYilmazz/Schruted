using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Schruted.EntityFrameworkCore;
using Schruted.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Schruted.Web.Tests
{
    [DependsOn(
        typeof(SchrutedWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SchrutedWebTestModule : AbpModule
    {
        public SchrutedWebTestModule(SchrutedEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchrutedWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SchrutedWebMvcModule).Assembly);
        }
    }
}