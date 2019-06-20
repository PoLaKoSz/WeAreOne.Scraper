using NUnit.Framework;
using System.Collections;

namespace PoLaKoSz.MusicFM.Tests.Unit
{
    class RadioStationTests
    {
        [TestCaseSource(typeof(StationNames))]
        public void NamePropertyDidNotChanged(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }

        class StationNames : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                var scraper = new WeAreOne.WeAreOne();

                yield return new object[] { "clubtime", scraper.ClubTime.Name };
                yield return new object[] { "coretime", scraper.CoreTime.Name };
                yield return new object[] { "hardbase", scraper.HardBase.Name };
                yield return new object[] { "housetime", scraper.HouseTime.Name };
                yield return new object[] { "teatime", scraper.TeaTime.Name };
                yield return new object[] { "technobase", scraper.TechoBase.Name };
                yield return new object[] { "trancebase", scraper.TranceBase.Name };
            }
        }
    }
}
