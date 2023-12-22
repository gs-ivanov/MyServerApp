namespace MyServer.Http
{
    using MyServer.Common;

    public class HttpHeader
    {
        public HttpHeader(string name, string value)
        {
            Guard.AgainstNull(name);
            Guard.AgainstNull(value);

            this.Name = name;
            this.Value = value;
        }

        public string Name { get; init; }
        public string Value { get; init; }

        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
}