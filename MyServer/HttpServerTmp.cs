namespace MyServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MyServer.Routing;

    public class HttpServerTmp
    {
        private readonly RoutingTable routingTable;

        public HttpServerTmp(Action<IRoutingTable> routingTableConfiguration)
        {
            this.routingTable = new RoutingTable();

            routingTableConfiguration(routingTable);
        }

        public async Task Start()
        {
            Console.WriteLine(9999);
            return;
        }
    }
}
