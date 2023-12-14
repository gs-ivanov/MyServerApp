namespace MyServer.Routing
{
    using System.Collections.Generic;
    using MyServer.Http;
    using MyServer.Responses;

    public class RoutingTable : IRoutingTable
    {
        private Dictionary<HttpMethod, Dictionary<string, HttpResponse>> routes;

        public RoutingTable()
        {
            this.routes = new()
            {
                [HttpMethod.Get] = new(),
                [HttpMethod.Post] = new(),
                [HttpMethod.Put] = new(),
                [HttpMethod.Delete] = new(),
            };
        }
        public IRoutingTable MapGet(string path, TextResponse response)
        {
            return null;
        }
    }
}
