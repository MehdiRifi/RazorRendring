using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorRendering
{
    public class RazorRendringModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ViewRender>().As<IViewRender>().InstancePerLifetimeScope();
            builder.RegisterType<ActionContextAccessor>().As<IActionContextAccessor>().InstancePerLifetimeScope();
            builder.Register(factory =>
            {
                var actionContext = factory.Resolve<IActionContextAccessor>()
                                               .ActionContext;
                return new UrlHelper(actionContext);
            }).As<IUrlHelper>();

        }
    }
}
