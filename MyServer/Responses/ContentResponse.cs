namespace MyServer.Responses
{
    using MyServer.Http;

    public class ContentResponse : HttpResponse
    {
        public ContentResponse(string text, string contentType)
            : base(HttpStatusCode.OK, text, contentType)
        {
        }
    }
}
