namespace MyServer
{
    using MyServer.Routing;
    using System;

    public class HttpServer
    {
        private readonly RoutingTable routingTable;

        public HttpServer(Action<IRoutingTable> routingTableConfiguration)
        {
            routingTableConfiguration(this.routingTable = new RoutingTable());
        }



        //public async Task Start()
        //{
        //    //return;

        //    this.listener.Start();

        //    Console.WriteLine($"Server started on port {port}...");
        //    Console.WriteLine("Listening for requests...");

        //    while (true)
        //    {
        //        var connection = await this.listener.AcceptTcpClientAsync();

        //        var networkStream = connection.GetStream();

        //        var requestText = await this.ReadRequest(networkStream);



        //        var request = HttpRequest.Parse(requestText);

        //        var response = this.routingTable.ExecuteRequest(request);

        //        await WriteResponse(networkStream,response);

        //        connection.Close();
        //    }
        //}
        //private async Task<string> ReadRequest(NetworkStream networkStream)
        //{
        //    var bufferLength = 1024;
        //    var buffer = new byte[bufferLength];

        //    var totalBytes = 0;

        //    var requestBuilder = new StringBuilder();

        //    do
        //    {
        //        var bytesRead = await networkStream.ReadAsync(buffer, 0, bufferLength);

        //        totalBytes += bytesRead;

        //        if (totalBytes > 10 * 1024)
        //        {
        //            throw new InvalidOperationException("Request is too large.");
        //        }

        //        requestBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));

        //    }
        //    while (networkStream.DataAvailable);



        //    return requestBuilder.ToString();
        //}

        //private async Task WriteResponse(
        //    NetworkStream networkStream,
        //    HttpResponse response)
        //{
        //    var responseBytes = Encoding.UTF8.GetBytes(response.ToString());

        //    await networkStream.WriteAsync(responseBytes);
        //}

        //// Git test
    }
}

