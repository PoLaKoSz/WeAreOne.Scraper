using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using PoLaKoSz.WeAreOne.DataAccessLayer.Web;

namespace PoLaKoSz.WeAreOne.Tests.Integration
{
    /// <summary>
    /// Mock the HttpClient. Use the ResponseFromServer property to change what
    /// should be returned from the fase server.
    /// </summary>
    class HttpClientMock : IHttpClient
    {
        public byte[] ResponseFromServer { get; set; }
        public Uri LastCalledURL { get; private set; }
        public Uri BaseAddress { get; }



        public HttpClientMock()
        {
            ResponseFromServer = new byte[0];

            BaseAddress = new Uri("https://polakosz.hu/");
        }



        /// <summary>
        /// Send a GET request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">The requestUri was null.</exception>
        /// <exception cref="HttpRequestException">The request failed due to an
        /// underlying issue such as network connectivity, DNS failure, server
        /// certificate validation or timeout.</exception>
        public Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            LastCalledURL = requestUri;

            var httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(ResponseFromServer)
            };

            return Task.Run(() => httpResponse);
        }
    }
}
