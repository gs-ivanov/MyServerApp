namespace MyServer.App
{
    using MyServer;
    using MyServer.Responses;
    using System.Threading.Tasks;
    using System;

    class Startup
    {
        // Thi is MyWork Branch

        public static void Main()
        {
            var obj = new HttpServer(routes => routes
              .MapGet("/c", request =>
           {
               var query = request.Query;
               var catName =
               query.ContainsKey("Name") ? query["Name"] : "The cats";
               var result = $"Hello from {catName}!";

               return new HtmlResponse(result);
           }));
              //.MapGet("/Dogs", new TextResponse("<h1>Hello from the dogs!</h1>")));
        }

        //public static async Task Main()
        //=> await new HttpServer(routes => routes
        // .MapGet("/c", request =>
        // {
        //     var query = request.Query;
        //     var catName =
        //     query.ContainsKey("Name") ? query["Name"] : "The cats";
        //     var result = $"Hello from {catName}!";

        //     return new HtmlResponse(result);
        // })
        //.MapGet("/", new TextResponse("Hello from Ivo!"))
        //.MapGet("/g", new TextResponse("Hello from George!"))
        //.MapGet("/Cats", new HtmlResponse("<h1>Hello from the cats!</h1>"))
        //.MapGet("/Dogs", new TextResponse("<h1>Hello from the dogs!</h1>"))
        //)
        // .Start();






    }
}
