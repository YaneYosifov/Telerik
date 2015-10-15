namespace ConsoleWebServer.Framework
{
    /// <summary>
    /// Interface to implement HTTP response
    /// </summary>
    public interface IActionResult
    {
        /// <summary>
        /// Gets HTTP response
        /// </summary>
        /// <returns>Response from the server</returns>
        HttpResponse GetResponse();
    }
}