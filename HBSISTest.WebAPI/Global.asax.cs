using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using HBSISTest.Application;
using HBSISTest.Application.Interfaces;
using HBSISTest.Domain.Interfaces.Repositories;
using HBSISTest.Domain.Interfaces.Services;
using HBSISTest.Domain.Services;
using HBSISTest.Infra.Data.Repositories;
using HBSISTest.WebAPI.AutoMapper;
using Ninject;
using Ninject.Web.Common.WebHost;

namespace HBSISTest.WebAPI
{
    public class WebApiApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind(typeof(IContribuinteAppService)).To(typeof(ContribuinteAppService));
            kernel.Bind(typeof(IAliquotaIrAppService)).To(typeof(AliquotaIrAppService));
            kernel.Bind(typeof(ISalarioMinimoAppService)).To(typeof(SalarioMinimoAppService));

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind(typeof(IContribuinteService)).To(typeof(ContribuinteService));
            kernel.Bind(typeof(IAliquotaIrService)).To(typeof(AliquotaIrService));
            kernel.Bind(typeof(ICpfService)).To(typeof(CpfService));
            kernel.Bind(typeof(ISalarioMinimoService)).To(typeof(SalarioMinimoService));

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind(typeof(IContribuinteRepository)).To(typeof(ContribuinteRepository));
            kernel.Bind(typeof(IAliquotaIrRepository)).To(typeof(AliquotaIrRepository));
            kernel.Bind(typeof(ISalarioMinimoRepository)).To(typeof(SalarioMinimoRepository));
        }
    }
}
