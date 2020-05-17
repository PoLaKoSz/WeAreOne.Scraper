using PoLaKoSz.WeAreOne.DataAccessLayer.Web;
using PoLaKoSz.WeAreOne.Models;
using PoLaKoSz.WeAreOne.Parsers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.EndPoints
{
    /// <summary>
    /// Class to access one of the WeAreOne radio station.
    /// <para>This class will be removed from the public API in the 2.0 release!
    /// Please use the <see cref="IRadioStation"/> interface instead!
    /// </para>
    /// </summary>
    [Obsolete("This class will be removed from the public API in the 2.0 release!" +
        " Please use the IRadioStation interface instead!", error: false)]
    public class RadioStation : EndPoint, IRadioStation
    {
        /// <inheritdoc />
        public string Name { get; }



        /// <summary>
        /// Initialize a new instance to access a radio.
        /// </summary>
        /// <param name="endPoint">Non null string.</param>
        /// <param name="httpClient">Non null object to access the web.</param>
        public RadioStation(string endPoint, IHttpClient httpClient)
            : base(endPoint, httpClient)
        {
            Name = endPoint;
        }



        /// <inheritdoc />
        public async Task<List<Music>> Tracklist()
        {
            string sourceCode = await base.GetAsync("tracklist");

            return TracklistParser.Process(sourceCode);
        }
    }
}
