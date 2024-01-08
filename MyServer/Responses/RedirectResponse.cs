namespace MyServer.Responses
{
    using MyServer.Http;

    public class RedirectResponse : HttpResponse
    {
        public RedirectResponse(string location)
            : base(HttpStatusCode.Found)
        => this.Headers.Add("Location", location);
    }
}
