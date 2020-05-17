using NUnit.Framework;
using PoLaKoSz.WeAreOne.EndPoints;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.Tests.Integration.EndPoints
{
    class CoreTimeTests : TestClassBase
    {
        private static readonly object[] Tracklist_2018_12_17;
        private readonly IRadioStation _coreTimeFM;



        static CoreTimeTests()
        {
            Tracklist_2018_12_17 = new[]
            {
                new object[] { "2018_12_17", new List<Music>()
                {
                    new Music("HT4L - Blood In My Eyes"),
                    new Music("Buchecha  - Around The Point"),
                    new Music("Richie Gee - He Eats People"),
                    new Music("Nobody - Ding Ding Dong"),
                    new Music("Monster Mush - Hardtechno Is Not A Crime"),
                    new Music("Mick - Stmlt"),
                    new Music("Instigator - 8x4"),
                    new Music("Buchecha - Black Signal"),
                    new Music("Andi Teller Vs. Pappenheimer - Zuckerwatte"),
                    new Music("Andi Teller - USB Anthem"),
                    new Music("Chor - Magic Box"),
                    new Music("Waldhaus - Konkupiszens"),
                    new Music("Gockel  - Stable Stab"),
                    new Music("Buchecha - Perfect Place"),
                    new Music("O.B.I. - Without Limitations"),
                    new Music("Mick, Chor - La Tuya"),
                    new Music("Jan Fleck - Rocket Power"),
                    new Music("HT4L - Love And Hate"),
                    new Music("Golpe - I Am Your Dealer"),
                    new Music("Gockel - Kernkraft"),
                    new Music("DJ Atom - Artificial Intelligence"),
                    new Music("Boris S. - I Wanna See Your Head Rockin"),
                    new Music("Bart Shadow - Magnets"),
                    new Music("Dave Blunt - Really Angry"),
                    new Music("Andi Teller - Crystal Meth"),
                    new Music("Hard J - Panic At The Dancefloor"),
                    new Music("Dragon Hoang - Hard Deaf"),
                    new Music("Double Dare - Intersection"),
                    new Music("Fl-X - Bicantista"),
                    new Music("Gockel - Techno Sequencer"),
                    new Music("Golpe - Defibrillator"),
                    new Music("HT4L - Your Nightmares Will Kill You"),
                    new Music("Greg Notill - Unsicher"),
                    new Music("Golpe - Dark Side"),
                    new Music("DJ Hammond - The Hive"),
                    new Music("Buchecha - Dogtown"),
                    new Music("Andi Teller - Head High"),
                    new Music("Bazz Dee - Pallim Pallim"),
                    new Music("Mental Crush - Lost In Spain"),
                    new Music("Sepromatiq  - Again 7"),
                    new Music("HT4L - Order 66"),
                    new Music("The Project - Darth Vader Vs. Luke Skywalker"),
                    new Music("PETDuo - Disruption"),
                    new Music("O.B.I. - Hold You Tonight"),
                    new Music("Mental Crush - Brain Damage"),
                }}
            };
        }

        public CoreTimeTests()
            : base("CoreTime")
        {
            _coreTimeFM = new WeAreOne(base.HttpClient).CoreTime;
        }



        [TestCaseSource(nameof(Tracklist_2018_12_17))]
        public async Task Can_Parse_Old_Tracklist(string date, List<Music> expected)
        {
            base.SetServerResponse(date);


            var actual = await _coreTimeFM.Tracklist();


            GenerateStaticTracklist(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
