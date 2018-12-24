using HtmlAgilityPack;
using PoLaKoSz.WeAreOne.DataAccessLayer.Web;
using PoLaKoSz.WeAreOne.Models;
using PoLaKoSz.WeAreOne.Parsers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.EndPoints
{
    /// <summary>
    /// Class to access one of the WeAreOne subradio.
    /// </summary>
    public class RadioStation : EndPoint
    {
        /// <summary>
        /// Initialize a new instance to access a radio.
        /// </summary>
        /// <param name="endPoint">Non null string.</param>
        /// <param name="httpClient">Non null object to access the web.</param>
        public RadioStation(string endPoint, IHttpClient httpClient)
            : base(endPoint, httpClient) { }



        /// <summary>
        /// Gets the radio's tracklist.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="NodeNotFoundException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        public async Task<List<Music>> Tracklist()
        {
            string sourceCode = await base.GetAsync("tracklist");

            return TracklistParser.Process(sourceCode);
        }
    }
}
