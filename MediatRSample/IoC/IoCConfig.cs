using Autofac;
using MediatR;
using System.Web.Http;

namespace MediatRSample.IoC
{
    public class IoCConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder
              .RegisterType<Mediator>()
              .As<IMediator>()
              .InstancePerLifetimeScope();

            // request & notification handlers
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            var container = builder.Build();
            //config.DependencyResolver = new Au(container);

            // finally register our custom code (individually, or via assembly scanning)
            // - requests & handlers as transient, i.e. InstancePerDependency()
            // - pre/post-processors as scoped/per-request, i.e. InstancePerLifetimeScope()
            // - behaviors as transient, i.e. InstancePerDependency()
            //builder.RegisterAssemblyTypes(typeof(MyType).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }
    }
}