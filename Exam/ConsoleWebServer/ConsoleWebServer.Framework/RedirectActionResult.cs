using System.Collections.Generic;
using ConsoleWebServer.Framework.ActionContent;
using ConsoleWebServer.Framework.Http;

namespace ConsoleWebServer.Framework
{
    public class RedirectActionResult : ContentActionResult
    {
        public RedirectActionResult(HttpRequest request, string model)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(model, request.Uri));
        }
    }
}
