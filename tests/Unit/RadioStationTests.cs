using NUnit.Framework;

namespace PoLaKoSz.MusicFM.Tests.Unit
{
    class RadioStationTests
    {
        private static readonly object[] _names;



        static RadioStationTests()
        {
            var scraper = new WeAreOne.WeAreOne();

            _names = new object[]
            {
                new object[] { "clubtime",   scraper.ClubTime.Name },
                new object[] { "coretime",   scraper.CoreTime.Name },
                new object[] { "hardbase",   scraper.HardBase.Name },
                new object[] { "housetime",  scraper.HouseTime.Name },
                new object[] { "teatime",    scraper.TeaTime.Name },
                new object[] { "technobase", scraper.TechoBase.Name },
                new object[] { "trancebase", scraper.TranceBase.Name },
            };
        }



        [TestCaseSource(nameof(_names))]
        public void Name_Property(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
