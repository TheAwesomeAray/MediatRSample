using Autofac;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediatRSample.IoC
{
    public class IoCStartUp
    {
        public static void Configure()
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

            // finally register our custom code (individually, or via assembly scanning)
            // - requests & handlers as transient, i.e. InstancePerDependency()
            // - pre/post-processors as scoped/per-request, i.e. InstancePerLifetimeScope()
            // - behaviors as transient, i.e. InstancePerDependency()
            //builder.RegisterAssemblyTypes(typeof(MyType).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }
    }
}