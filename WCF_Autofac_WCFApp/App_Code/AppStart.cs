using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Autofac_WCFApp.App_Code
{
    public static class AppStart
    {
        public static void AppInitialize()
        {
            AutofacHostFactory.Container = new AutofacBootstrapper().Configure();
        }
    }
}