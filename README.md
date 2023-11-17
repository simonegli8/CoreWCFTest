# CoreWCFTest

A server and a client to test CoreWCF. This code is derives from the CoreWCF.Samples Basic sample. It uses NetHttpBinding, which causes
CoreWCF to crash.

In order to reproduce the bug, set Service as startup project and start without debugging, then set startup project to Client and run.

The server reports the following exception:

      Connection id "0HMV7I2VBF8R4", Request id "0HMV7I2VBF8R4:00000002": An unhandled exception was thrown by the application.
      System.NullReferenceException: Object reference not set to an instance of an object.
         at CoreWCF.Channels.RequestDelegateHandler.HandleRequest(HttpContext context)
         at CoreWCF.Channels.ServiceModelHttpMiddleware.InvokeAsync(HttpContext context)
         at CoreWCF.Channels.MetadataMiddleware.InvokeAsync(HttpContext context)
         at Microsoft.WebTools.BrowserLink.Net.BrowserLinkMiddleware.InvokeAsync(HttpContext context)
         at Microsoft.AspNetCore.Watch.BrowserRefresh.BrowserRefreshMiddleware.InvokeAsync(HttpContext context)
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
