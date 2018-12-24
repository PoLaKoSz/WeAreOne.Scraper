using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.DataAccessLayer.Web
{
    /// <summary>
    /// Simple web access layer only for the bare minimum.
    /// </summary>
    public abstract class EndPoint
    {
        private readonly Uri _baseAddress;

        /// <summary>
        /// This instance handles the web access.
        /// </summary>
        protected IHttpClient Client;



        /// <summary>
        /// Initialize a new Instance.
        /// </summary>
        /// <param name="endPoint">Non null string.</param>
        /// <param name="httpClient">Non null object.</param>
        public EndPoint(string endPoint, IHttpClient httpClient)
        {
            _baseAddress = new Uri("http://" + endPoint + ".fm/");

            Client = httpClient;
        }



        /// <summary>
        /// Send a GET request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <param name="path">End path where the request is sent to.</param>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue
        /// such as network connectivity, DNS failure, server certificate validation, timeout or
        /// other than HTTP 200 response.</exception>
        /// <exception cref="InvalidCastException">An unknown Exception received from the server.</exception>
        protected async Task<string> GetAsync(string path)
        {
            var uriBuilder = new UriBuilder(_baseAddress);
            uriBuilder.Path += path;

            HttpResponseMessage response = await Client.GetAsync(uriBuilder.Uri);

            byte[] byteArray = await response.Content.ReadAsByteArrayAsync();

            if (response.StatusCode != HttpStatusCode.OK)
                throw new HttpRequestException($"HTTP {response.StatusCode} returned while loading {uriBuilder.Uri}");

            // For future Integration tests
            //System.IO.File.WriteAllBytes($"{uriBuilder.Host}.html", byteArray);

            return Encoding.GetEncoding("ISO-8859-1").GetString(byteArray, 0, byteArray.Length);
        }
    }
}
