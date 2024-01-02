namespace MyServer.Routing
{
    using MyServer.Http;
    using System;

    public interface IRoutingTable
    {
        public IRoutingTable Map(HttpMethod method, string path, HttpResponse response);
        
        public IRoutingTable Map(HttpMethod method, string path, Func<HttpRequest, HttpResponse> responseFunction);
       
        public IRoutingTable MapGet(string path, HttpResponse response);
       
        public IRoutingTable MapGet(string path, Func<HttpRequest, HttpResponse> responseFunction);

        public IRoutingTable MapPost(string path, HttpResponse response);

        public IRoutingTable MapPost(string path, Func<HttpRequest, HttpResponse> responseFunction);
    }
}
