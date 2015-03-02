/*
 * Write a program that downloads a file from Internet 
 * (e.g. Ninja image) and stores it the current directory.
 * Find in Google how to download files in C#.
 * Be sure to catch all exceptions and to free 
 * any used resources in the finally block.
 */

using System;
using System.Net;
public class DownloadFile
{
    public static void Main()
    {
        try
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
                Console.WriteLine("Download complete!");
            }
        }
        catch (WebException e)
        {
            if (e.Status == WebExceptionStatus.CacheEntryNotFound)
            {
                Console.Error.WriteLine("The specified cache entry was not found.");
            }
            if (e.Status == WebExceptionStatus.ConnectFailure)
            {
                Console.Error.WriteLine("The remote service point could not be contacted at the transport level.");
            }
            if (e.Status == WebExceptionStatus.ConnectionClosed)
            {
                Console.Error.WriteLine("The connection was prematurely closed.");
            }
            if (e.Status == WebExceptionStatus.KeepAliveFailure)
            {
                Console.Error.WriteLine("The connection for a request that specifies the Keep-alive header was closed unexpectedly.");
            }
            if (e.Status == WebExceptionStatus.MessageLengthLimitExceeded)
            {
                Console.Error.WriteLine("A message was received that exceeded the specified limit when sending a request or receiving a response from the server.");
            }
            if (e.Status == WebExceptionStatus.NameResolutionFailure)
            {
                Console.Error.WriteLine("The name resolver service could not resolve the host name.");
            }
            if (e.Status == WebExceptionStatus.Pending)
            {
                Console.Error.WriteLine("An internal asynchronous request is pending.");
            }
            if (e.Status == WebExceptionStatus.PipelineFailure)
            {
                Console.Error.WriteLine("The request was a piplined request and the connection was closed before the response was received.");
            }
            if (e.Status == WebExceptionStatus.ProtocolError)
            {
                Console.Error.WriteLine("The response received from the server was complete but indicated a protocol-level error.");
            }
            if (e.Status == WebExceptionStatus.ProxyNameResolutionFailure)
            {
                Console.Error.WriteLine("The name resolver service could not resolve the proxy host name.");
            }
            if (e.Status == WebExceptionStatus.ReceiveFailure)
            {
                Console.Error.WriteLine("A complete response was not received from the remote server.");
            }
            if (e.Status == WebExceptionStatus.RequestCanceled)
            {
                Console.Error.WriteLine("The request was canceled, the WebRequest.Abort method was called, or an unclassifiable error occurred.");
            }
            if (e.Status == WebExceptionStatus.RequestProhibitedByCachePolicy)
            {
                Console.Error.WriteLine("The request was not permitted by the cache policy. In general, this occurs when a request is not cacheable and the effective policy prohibits sending the request to the server.");
            }
            if (e.Status == WebExceptionStatus.RequestProhibitedByProxy)
            {
                Console.Error.WriteLine("This request was not permitted by the proxy.");
            }
            if (e.Status == WebExceptionStatus.SecureChannelFailure)
            {
                Console.Error.WriteLine("An error occurred while establishing a connection using SSL.");
            }
            if (e.Status == WebExceptionStatus.SendFailure)
            {
                Console.Error.WriteLine("A complete request could not be sent to the remote server.");
            }
            if (e.Status == WebExceptionStatus.ServerProtocolViolation)
            {
                Console.Error.WriteLine("The server response was not a valid HTTP response.");
            }
            if (e.Status == WebExceptionStatus.Success)
            {
                Console.Error.WriteLine("No error was encountered.");
            }
            if (e.Status == WebExceptionStatus.Timeout)
            {
                Console.Error.WriteLine("No response was received during the time-out period for a request.");
            }
            if (e.Status == WebExceptionStatus.TrustFailure)
            {
                Console.Error.WriteLine("A server certificate could not be validated.");
            }
            if (e.Status == WebExceptionStatus.UnknownError)
            {
                Console.Error.WriteLine("An exception of unknown type has occurred.");
            }
        }
        catch (Exception)
        {
            Console.Error.WriteLine("An error occured.");
        }
    }
}