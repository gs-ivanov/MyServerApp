namespace MyServer.App
{
    using MyServer.Responses;

    class Startup
    {
        // Thi is MyWork Branch

        public static void Main()
        {
            var x = new HttpServer(routes => routes
                  .MapGet("/c", new HtmlResponse("Hi!"))
                  //.MapGet("/c", request =>
                  //{
                  //    var query = request.Query;
                  //    var catName = query.ContainsKey("Name")
                  //    ? query["Name"] : "The Cats";
                  //    return new HtmlResponse(catName);
                  //})
                 );
        }


    }
}
