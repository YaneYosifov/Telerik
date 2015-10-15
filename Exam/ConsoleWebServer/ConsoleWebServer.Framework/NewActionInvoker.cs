namespace ConsoleWebServer.Framework
{
    internal class NewActionInvoker
    {
        public IActionResult InvokeAction(Controller controller, ActionDescriptor actionDescriptor)
        {
            // TODO: useless var to remove?
            // var className = HttpNotFound.ClassName;
            return new ActionInvoker().InvokeAction(controller, actionDescriptor);
        }
    }
}