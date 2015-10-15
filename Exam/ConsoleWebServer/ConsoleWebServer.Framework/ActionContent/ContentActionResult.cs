namespace ConsoleWebServer.Framework.ActionContent
{
    using System.Collections.Generic;
    using System.Net;
    using ConsoleWebServer.Framework.ActionCommon;
    using ConsoleWebServer.Framework.Http;

    public class ContentActionResult : IActionResult
    {
        public readonly object Model;

        public ContentActionResult(HttpRequest request, object model)
        {
            this.Model = model;
            this.Request = request;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        public HttpRequest Request { get; private set; }

        public List<KeyValuePair<string, string>> ResponseHeaders { get; private set; }

        public HttpResponse GetResponse()
        {
            var response = new HttpResponse(
            this.Request.ProtocolVersion,
            HttpStatusCode.OK,
            this.Model.ToString(),
            "text/plain; charset=utf-8");
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}