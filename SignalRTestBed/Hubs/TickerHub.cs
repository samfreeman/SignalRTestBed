
using Microsoft.AspNet.SignalR;


namespace SignalRTestBed.Hubs
{
	public class TickerHub : Hub
	{
		public void Hello()
		{
			Clients.All.hello();
		}
	}
}
