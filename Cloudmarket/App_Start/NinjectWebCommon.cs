[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(App_Start.NinjectWebCommon), "Stop")]

namespace App_Start
{
    using System;
    using System.Web;
    using Cloudmarket.Application;
    using Cloudmarket.Application.Interface;
    using Cloudmarket.Domain.Interfaces;
    using Cloudmarket.Infra.Data.Repository;
    using Cloudmarkt.Domain.Services;
    using Domain.Interfaces;
    using Domain.Interfaces.Services;
    using Domain.Services;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Repository.Data.Repository;

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
            kernel.Bind<ICarrinhoSessionAppService>().To<CarrinhoSessionAppService>();
            kernel.Bind<ICompraAppService>().To<CompraAppService>();
            kernel.Bind<IEnderecoAppService>().To<EnderecoAppService>();
            kernel.Bind<IPagamentoAppService>().To<PagamentoAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
            kernel.Bind<IUsuarioAppService>().To<UsuarioAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ICarrinhoSessionService>().To<CarrinhoSessionService>();
            kernel.Bind<ICompraService>().To<CompraService>();
            kernel.Bind<IEnderecoService>().To<EnderecoService>();
            kernel.Bind<IPagamentoService>().To<PagamentoService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();
            kernel.Bind<IUsuarioService>().To<UsuarioService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ICarrinhoSessionRepository>().To<CarrinhoSessionRepository>();
            kernel.Bind<ICompraRepository>().To<CompraRepository>();
            kernel.Bind<IEnderecoRepository>().To<EnderecoRepository>();
            kernel.Bind<IPagamentoRepository>().To<PagamentoRepository>();
            kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>();
        }
    }
}
