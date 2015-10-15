namespace ConsoleWebServer.Framework
{
    /// <summary>
    /// Interface to implement HTTP response
    /// </summary>
    public interface IResponseProvider
    {
        /// <summary>
        /// Gets HTTP response
        /// </summary>
        /// <param name="requestAsString">Request in string format</param>
        /// <returns>Response from the server</returns>
        HttpResponse GetResponse(string requestAsString);
    }
}