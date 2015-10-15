namespace ConsoleWebServer.Framework.ActionJson
{
    using System.Collections.Generic;
    using ConsoleWebServer.Framework.Http;

    public class JsonActionResultWithoutCaching : JsonActionResult
    {
        public JsonActionResultWithoutCaching(HttpRequest request, object model)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
        }
    }
}