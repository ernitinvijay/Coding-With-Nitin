using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;
using Autofac.Util;
using Autofac.Integration.Mvc;
using Demo.BusinessLogic;
using Demo.Database;
using AutoMapper;
using MVCDemo.Mapping;

using System.Data.Entity;

namespace MVCDemo
{
    public static class AutofacConfigratin
    {


        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // OPTIONAL: Enable action method parameter injection (RARE).
            builder.Register(x=>AutomapperConfi.AutoConfiguration()).As<IMapper>().SingleInstance();
            builder.RegisterType<DemoContext>().AsImplementedInterfaces()
  .InstancePerLifetimeScope();
            builder.RegisterType<EmployeeUOW>().As<IEmployeeUOW>().InstancePerRequest();
            builder.RegisterType<EmployeeRepostory>().As<IEmployeeRepostory>().InstancePerRequest();
            builder.RegisterType<EmployeeProcessor>().As<IEmployeeProcessor>().InstancePerRequest();
            

             // Set the dependency resolver to be Autofac.
             var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}