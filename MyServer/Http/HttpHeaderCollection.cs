namespace MyServer.Http
{
    using System.Collections;
    using System.Collections.Generic;

    public class HttpHeaderCollection : IEnumerable<HttpHeader>
    {
        IEnumerator<HttpHeader> IEnumerable<HttpHeader>.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}