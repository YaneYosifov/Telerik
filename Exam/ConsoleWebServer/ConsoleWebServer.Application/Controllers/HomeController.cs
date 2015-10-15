using System;

namespace ConsoleWebServer.Application.Controllers
{
    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.ActionCommon;
    using ConsoleWebServer.Framework.ActionContent;
    using ConsoleWebServer.Framework.Http;
    using System.Net;

    public class HomeController : Controller
    {
        public HomeController(HttpRequest request)
            : base(request)
        {
        }

        public IActionResult Index(string param)
        {
            return this.Content("Home page :)");
        }

        public IActionResult Forum(string param)
        {
            return new RedirectActionResult(this.Request, "Location:");
;
        }

        public IActionResult LivePage(string param)
        {
            return new ContentActionResultWithoutCaching(this.Request, "Live page with no caching");
        }

        public IActionResult LivePageForAjax(string param)
        {
            return new ContentActionResultWithCorsWithoutCaching(this.Request, "Live page with no caching and CORS", "*");
        }
    }
}