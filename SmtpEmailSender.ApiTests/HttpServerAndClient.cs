using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SmtpEmailSender.ApiTests
{
    public class HttpServerAndClient<T> : IDisposable
    {
        public readonly HttpClient Client;
        public readonly IDisposable Server;
        
        public HttpServerAndClient()
        {
            var l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();

            string address = "http://localhost:" + port.ToString();

            Server = WebApp.Start<T>(address);

            Client = new HttpClient();
            Client.BaseAddress = new Uri(address);

        }

        public void Dispose() { }

        //#region IDisposable
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        ////// NOTE: Leave out the finalizer altogether if this class doesn't   
        ////// own unmanaged resources itself, but leave the other methods  
        ////// exactly as they are.   
        ////~HttpServerAndClient()
        ////{
        ////    // Finalizer calls Dispose(false)  
        ////    Dispose(false);
        ////}

        //protected virtual void Dispose(bool disposing)
        //{
        //    //if (disposing)
        //    //{
        //    //    // free managed resources  
        //    //    if (managedResource != null)
        //    //    {
        //    //        managedResource.Dispose();
        //    //        managedResource = null;
        //    //    }
        //    //}
        //    //// free native resources if there are any.  
        //    //if (nativeResource != IntPtr.Zero)
        //    //{
        //    //    Marshal.FreeHGlobal(nativeResource);
        //    //    nativeResource = IntPtr.Zero;
        //    //}
        //}
        //#endregion

    }

}
