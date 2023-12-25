namespace MyServer.Http
{
    using System;
    using System.Text;

    public abstract class HttpResponse
    {
        public HttpResponse(HttpStatusCode statusCode,string path,string contentType)
        {
            this.StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; init; }

        public HttpHeaderCollection Headers { get; } = new HttpHeaderCollection();

        public string Content{ get; init; }



            Console.WriteLine(result.ToString()); 

            return result.ToString();
        }

    }
}
