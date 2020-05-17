using HtmlAgilityPack;
using PoLaKoSz.WeAreOne.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.EndPoints
{
    /// <summary>
    /// Provides access one of the WeAreOne radio station.
    /// </summary>
    public interface IRadioStation
    {
        /// <summary>
        /// The full name of the station. For ex.: technobase, teatime, etc.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the radio's tracklist.
        /// </summary>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="NodeNotFoundException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        Task<List<Music>> Tracklist();
    }
}
