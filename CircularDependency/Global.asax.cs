using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CircularDependency
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var Builder = new ContainerBuilder();
            Builder.RegisterType<Dependencies >().As<IDependencies>().SingleInstance();
            Builder.RegisterType<Home>().As<IHome>();
            Builder.RegisterType<Vechile>().As<IVechile>();
            Builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = Builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
