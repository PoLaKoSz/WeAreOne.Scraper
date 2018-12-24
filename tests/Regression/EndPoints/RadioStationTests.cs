using NUnit.Framework;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.Tests.Regression.EndPoints
{
    class RadioStationTests
    {
        private readonly WeAreOne _weAreOne;



        public RadioStationTests()
        {
            _weAreOne = new WeAreOne();
        }



        [Test]
        public async Task Can_Scrape_Live_TechnoBaseFM_Tracklist()
        {
            List<Music> tracklist = await _weAreOne.TechoBase.Tracklist();

            Assert.That(tracklist.Count, Is.GreaterThan(30), "tracklist.Count");
        }

        [Test]
        public async Task Can_Scrape_Live_HouseTimeFM_Tracklist()
        {
            List<Music> tracklist = await _weAreOne.HouseTime.Tracklist();

            Assert.That(tracklist.Count, Is.GreaterThan(30), "tracklist.Count");
        }

        [Test]
        public async Task Can_Scrape_Live_HardBaseFM_Tracklist()
        {
            List<Music> tracklist = await _weAreOne.HardBase.Tracklist();

            Assert.That(tracklist.Count, Is.GreaterThan(30), "tracklist.Count");
        }

        [Test]
        public async Task Can_Scrape_Live_TranceBaseFM_Tracklist()
        {
            List<Music> tracklist = await _weAreOne.TranceBase.Tracklist();

            Assert.That(tracklist.Count, Is.GreaterThan(30), "tracklist.Count");
        }

        [Test]
        public async Task Can_Scrape_Live_CoreTimeFM_Tracklist()
        {
            List<Music> tracklist = await _weAreOne.CoreTime.Tracklist();

            Assert.That(tracklist.Count, Is.GreaterThan(30), "tracklist.Count");
        }

        [Test]
        public async Task Can_Scrape_Live_ClubTimeFM_Tracklist()
        {
            List<Music> tracklist = await _weAreOne.ClubTime.Tracklist();

            Assert.That(tracklist.Count, Is.GreaterThan(30), "tracklist.Count");
        }

        [Test]
        public async Task Can_Scrape_Live_TeaTimeFM_Tracklist()
        {
            List<Music> tracklist = await _weAreOne.TeaTime.Tracklist();

            Assert.That(tracklist.Count, Is.GreaterThan(30), "tracklist.Count");
        }
    }
}
