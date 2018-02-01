
using System.Web.Mvc;
using System.Web.Routing;

using Owin;


namespace SignalRTestBed
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			app.MapSignalR();
		}
	}
}
