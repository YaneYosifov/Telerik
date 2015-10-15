namespace ConsoleWebServer.Framework
{
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json;

    public class JsonActionResult : IActionResult
    {
        public readonly object Model;

        public JsonActionResult(HttpRq rq, object m)
        {
            this.Model = m;
            this.Request = rq;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        public HttpRq Request { get; private set; }

        public List<KeyValuePair<string, string>> ResponseHeaders { get; private set; }

        public virtual HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.OK;
        }

        public string GetContent()
        {
            return JsonConvert.SerializeObject(this.Model);
        }

        public HttpResponse GetResponse()
        {
            var response = new HttpResponse(
                this.Request.ProtocolVersion, 
                this.GetStatusCode(), 
                this.GetContent(),
                HighQualityCodeExamPointsProvider.GetContentType());
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}