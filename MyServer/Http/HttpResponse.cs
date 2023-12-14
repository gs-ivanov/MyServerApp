namespace MyServer.Http
{
    using MyServer.Http;
    public abstract class HttpResponse
    {
        public HttpResponse(HttpStatusCode statusCode,string path,string contentType)
        {
            this.StatusCode = statusCode;
            this.Path = path;
            this.ContentType = contentType;
        }

        public HttpStatusCode StatusCode { get; init; }

        public string Path{ get; init; }

        public string ContentType{ get; init; }


    }
}
