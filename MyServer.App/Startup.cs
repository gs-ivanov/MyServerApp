namespace MyServer.App
{
    using MyServer.Responses;
    using MyServer.Routing;
    using MyServer.Common;
    using MyServer.Http;
    using System;

    class Startup
    {
        public static void Main()
        {
            //Action<IRoutingTable> action = t => t.MapGet("/Cats",new TextResponse("Hi"));

            //var y = new RoutingTable();

            //action(y);

            //object text = null;

            //Guard.AgainstNull(text, "Koo?");

            //var a = new HttpHeader("Date", $"{DateTime.UtcNow}");


            var x = new HttpServer(routes => routes
              .MapGet("/Cats", new TextResponse("Hi!")));
        }
    }
}
