using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using WCF_Autofac.WCF;

namespace WCF_Autofac.App_Start
{
    public class AutofacBootstrapper
    {
        public IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TestService>().As<ITestService>();

            return builder.Build();
        }
    }
}