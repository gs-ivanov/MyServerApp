namespace MyServer.App
{
    using MyServer;
    using MyServer.Responses;
    using System.Threading.Tasks;
    using System;

    class Startup
    {

        public static async Task Main()
        => await new HttpServer(routes => routes
         .MapGet("/c", request =>
         {
             var query = request.Query;
             var catName =
             query.ContainsKey("Name") ? query["Name"] : "The cats";
             var result = $"<h1>Hello from {catName}!</h1>";

             return new HtmlResponse(result);
         })
        .MapGet("/", new TextResponse("Hello from Ivo!"))
        .MapGet("/Cats", new TextResponse("<h1>Hello from the cats!</h1>"))
        .MapGet("/Dogs", new TextResponse("<h1>Hello from the dogs!</h1>"))
        )
         .Start();






    }
}
