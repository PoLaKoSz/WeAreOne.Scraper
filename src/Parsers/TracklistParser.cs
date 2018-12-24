using HtmlAgilityPack;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;

namespace PoLaKoSz.WeAreOne.Parsers
{
    internal static class TracklistParser
    {
        /// <summary>
        /// Extract the <see cref="Music"/>s from the HTML.
        /// </summary>
        /// <param name="sourceCode">Non null string.</param>
        /// <returns>Non null <see cref="Music"/> collection.</returns>
        /// <exception cref="NodeNotFoundException"></exception>
        public static List<Music> Process(string sourceCode)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(sourceCode);

            var songNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='news2']/div/table/tbody/tr/th");

            if (songNodes == null)
                throw new NodeNotFoundException("Couldn't find songs with the given XPath!");

            var tracks = new List<Music>();

            for (int i = 0; i < songNodes.Count; i++)
            {
                string music = songNodes[i].InnerText.Trim();

                music = HtmlEntity.DeEntitize(music);

                tracks.Add(new Music(music));
            }

            return tracks;
        }
    }
}
