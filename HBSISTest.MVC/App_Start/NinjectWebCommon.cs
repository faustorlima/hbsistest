[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HBSISTest.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(HBSISTest.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace HBSISTest.MVC.App_Start
{
    using System;
    using System.Web;
    using HBSISTest.Application;
    using HBSISTest.Application.Interfaces;
    using HBSISTest.Domain.Interfaces.Repositories;
    using HBSISTest.Domain.Interfaces.Services;
    using HBSISTest.Domain.Services;
    using HBSISTest.Infra.Data.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind(typeof(IClienteAppService)).To(typeof(ClienteAppService));
            kernel.Bind(typeof(IProdutoAppService)).To(typeof(ProdutoAppService));

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind(typeof(IClienteService)).To(typeof(ClienteService));
            kernel.Bind(typeof(IProdutoService)).To(typeof(ProdutoService));

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind(typeof(IClienteRepository)).To(typeof(ClienteRepository));
            kernel.Bind(typeof(IProdutoRepository)).To(typeof(ProdutoRepository));
        }        
    }
}
