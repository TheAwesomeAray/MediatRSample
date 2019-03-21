using Application.Commands;
using Application.Interfaces;
using Autofac;
using Autofac.Integration.WebApi;
using Infrastructure;
using MediatR;
using System.Reflection;
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

            builder.RegisterType<RequestContext>()
                   .As<IRequestRepository>();

            // request & notification handlers
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(typeof(UpdateRequestCommand).GetTypeInfo().Assembly).AsImplementedInterfaces();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            // finally register our custom code (individually, or via assembly scanning)
            // - requests & handlers as transient, i.e. InstancePerDependency()
            // - pre/post-processors as scoped/per-request, i.e. InstancePerLifetimeScope()
            // - behaviors as transient, i.e. InstancePerDependency()
            
        }
    }
}