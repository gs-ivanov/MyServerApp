namespace MyServer.Routing
{
    using MyServer.Http;
    using MyServer.Responses;

    public interface IRoutingTable
    {
        IRoutingTable MapGet(string path, TextResponse response);
    }
}
