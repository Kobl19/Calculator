﻿using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TestCalculator.Util;

namespace TestCalculator
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            App_Start.AutoMapperConfig.Initialize();

            NinjectModule Module = new UtilModule();
            var kernel = new StandardKernel(Module);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
