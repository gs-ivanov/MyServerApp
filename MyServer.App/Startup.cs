namespace MyServer.App
{
    using MyServer.Responses;
    using MyServer.Routing;
    using System;

    class Startup
    {
        public static void Main()
        {
            Action<IRoutingTable> action = t => t.MapGet("/Cats",new TextResponse("Hi"));

            var y = new RoutingTable();

            action(y);

            //var x = new HttpServer(routes => routes
            //  .MapGet("/Cats", new TextResponse("Hi!")));
        }
    }
}
