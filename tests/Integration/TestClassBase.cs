using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.IO;

namespace PoLaKoSz.WeAreOne.Tests.Integration
{
    internal abstract class TestClassBase
    {
        private readonly string _path;
        private readonly string _module;

        /// <summary>
        /// Set to true when You want to add a new StaticResource .html file.
        /// </summary>
        private readonly bool _shouldCreateNewTracklist;

        protected readonly HttpClientMock HttpClient;



        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="module">Non null name of the module (subdirectory).</param>
        public TestClassBase(string module)
        {
            _module = module;
            _path = Path.Combine("StaticResources", _module);
            _shouldCreateNewTracklist = !true;

            HttpClient = new HttpClientMock();
        }



        /// <summary>
        /// Get the source code from a previously saved HTML file.
        /// </summary>
        protected void SetServerResponse(string fileName)
        {
            HttpClient.ResponseFromServer = File.ReadAllBytes(Path.Combine(_path, $"{fileName}.html"));
        }

        /// <summary>
        /// Saves the tracklist to a file to make a new StaticResource
        /// addig more faster.
        /// </summary>
        /// <param name="tracklist">Non null <see cref="Music"/> collection.</param>
        protected void GenerateStaticTracklist(List<Music> tracklist)
        {
            if (!_shouldCreateNewTracklist)
                return;

            File.Delete($"{_module}.txt");

            foreach (var music in tracklist)
            {
                File.AppendAllText($"{_module}.txt", $"\t\t\t\t\tnew Music(\"{music.Name}\"),\n");
            }
        }
    }
}
