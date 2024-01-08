namespace MyServer.App
{
    using MyServer;
    using MyServer.Controllers;
    using MyServer.Responses;
    using System.Threading.Tasks;
    using System;
    using MyServer.App.Controllers;

    class Startup
    {

        public static async Task Main()
        => await new HttpServer(routes => routes
        .MapGet<HomeController>("/", c=>c.Index())
        .MapGet<AnimalsController>("/Cats", c => c.Cats())
        .MapGet<AnimalsController>("/Dogs", c => c.Dogs())
        )
         .Start();






    }
}
