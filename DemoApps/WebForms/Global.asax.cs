using Autofac;
using Autofac.Integration.Web;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebForms
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;
        IContainer container;

        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureContainer();
            ConfigDataBase();
            this.BeginRequest += Application_BeginRequest;
        }

        protected void Application_Error(Object sender, EventArgs e)
        {
            var raisedException = Server.GetLastError();
            Trace.TraceError($"Unhandled exeption WebForms: {raisedException}");
        }

        protected virtual void Application_BeginRequest(object sender, EventArgs e)
        {
            var url = Request.Url.AbsoluteUri;
            Trace.TraceInformation($"Received request {url}.");
        }

        /// <summary>
        /// http://docs.autofac.org/en/latest/integration/webforms.html
        /// </summary>
        private void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new ApplicationModule());
            container = builder.Build();
            _containerProvider = new ContainerProvider(container);
        }

        private void ConfigDataBase()
        {
            Database.SetInitializer<BeersContext>(container.Resolve<BeersDBInitializer>());
        }
    }
}