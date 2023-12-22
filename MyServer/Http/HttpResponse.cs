namespace MyServer.Http
{
    using MyServer.Http;
    public abstract class HttpResponse
    {
        public HttpResponse(HttpStatusCode statusCode)
        {
            this.StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; init; }

        public HttpHeaderCollection Headers { get; } = new HttpHeaderCollection();

        public string Content{ get; init; }



        public string ContentType{ get; init; }


    }
}
