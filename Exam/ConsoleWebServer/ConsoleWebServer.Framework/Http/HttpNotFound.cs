namespace ConsoleWebServer.Framework.Http
{
    using System;
    using ConsoleWebServer.Framework.ActionCommon;

    public class HttpNotFound : Exception
    {
        public const string ClassName = "HttpNotFoundException";

        public HttpNotFound(string message)
            : base(message)
        {
        }

        public class ParserException : Exception
        {
            // TODO: to remove "request" parameter?
            public ParserException(string message, ActionDescriptor request = null)
                : base(message)
            {
            }
        }
    }
}