namespace MyServer.App
{
    using MyServer.Responses;
    using System.Threading.Tasks;

    class Startup
    {
        public static async Task Main()
        => await new HttpServer(routes => routes
              .MapGet("/", new TextResponse("Hello from Ivo!"))
              .MapGet("/c", request =>
              {
                  const string nameKey = "Name";
                  var query = request.Query;

                  var catName = query.ContainsKey(nameKey)
                  ? query[nameKey]
                  : "the cats";

                  return new HtmlResponse($"<h1>Hello from {catName}!</h1>");
              })
              .MapGet("/Dogs", new HtmlResponse("Hello from Ivo!"))
              .MapGet("/Cats", new HtmlResponse("Hello from Ivo!")))
           .Start();
    }
}
