namespace MyServer.App
{
    using MyServer.Responses;
    using MyServer.Routing;
    using System.Threading.Tasks;
    using System;

    class Startup
    {
        //public static async Task Main()
        //=> await new HttpServer(routes => routes
        //      .MapGet("/", new TextResponse("Hello from Ivo!"))
        //      .MapGet("/c", request =>
        //      {
        //          const string nameKey = "Name";
        //          var query = request.Query;

        //          var catName = query.ContainsKey(nameKey)
        //          ? query[nameKey]
        //          : "the cats";

        //          return new HtmlResponse($"<h1>Hello from {catName}!</h1>");
        //      })
        //      .MapGet("/Dogs", new HtmlResponse("Hello from Ivo!"))
        //      .MapGet("/Cats", new HtmlResponse("Hello from Ivo!")))
        //   .Start();
        class MyServer
        {
            private readonly RoutingTable routingTable;

            public MyServer(Action<IRoutingTable> routingTableConfiguration)
            {
                this.routingTable = new RoutingTable();

                routingTableConfiguration(routingTable);
            }



        }

        public static void Main()
        {
            //var x = new MyServer(route => route
            //  .MapGet("/", new HtmlResponse("<h1>Hello from Iva!</h1>")));

            Action<IRoutingTable> action = route => route.MapGet("/Cats", new TextResponse("hi!!"));

            var rTable = new RoutingTable();

            action(rTable);
        
        }
    }
}
