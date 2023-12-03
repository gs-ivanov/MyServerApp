namespace MyServer.Responses
{
    public class TestResponse : ContentResponse
    {
        public TestResponse(string text)
            : base(text, "text/plain; charset=UTF-8")
        {
        }
    }
}
