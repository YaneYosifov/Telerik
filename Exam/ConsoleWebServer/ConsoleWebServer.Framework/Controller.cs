namespace ConsoleWebServer.Framework
{
    using ConsoleWebServer.Framework.ActionCommon;
    using ConsoleWebServer.Framework.ActionContent;
    using ConsoleWebServer.Framework.ActionJson;
    using ConsoleWebServer.Framework.Http;

    public abstract class Controller
    {
        protected Controller(HttpRequest request)
        {
            this.Request = request;
        }

        public HttpRequest Request { get; private set; }

        protected IActionResult Content(object model)
        {
            return new ContentActionResult(this.Request, model);
        }

        protected IActionResult Json(object model)
        {
            return new JsonActionResult(this.Request, model);
        }

        protected RedirectActionResult Redirect(string uri)
        {
            return new RedirectActionResult(this.Request, uri);
        }
    }
}