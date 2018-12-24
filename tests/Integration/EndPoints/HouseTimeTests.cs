using NUnit.Framework;
using PoLaKoSz.WeAreOne.EndPoints;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.Tests.Integration.EndPoints
{
    class HouseTimeTests : TestClassBase
    {
        private static readonly object[] Tracklist_2018_12_17;
        private readonly RadioStation _houseTimeFM;



        static HouseTimeTests()
        {
            Tracklist_2018_12_17 = new[]
            {
                new object[] { "2018_12_17", new List<Music>()
                {
                    new Music("Coone & Hard Driver - It's All In The Game (Official Intents Festival 2016 Anthem)"),
                    new Music("Hardwell - Wake Up Call"),
                    new Music("Dimitri Vegas & Like Mike vs. W&W - Waves (Tomorrowland 2014 Anthem)"),
                    new Music("Tom & Jane - Find You"),
                    new Music("Joey Dale  - Haunted House"),
                    new Music("DVBBS & Dropgun feat. Sanjin - Pyramids"),
                    new Music("Hardwell & W&W - Jumper"),
                    new Music("DVBBS & Jay Hardway - Voodoo"),
                    new Music("Blasterjaxx & DBSTF  - Parnassia"),
                    new Music("Deorro vs. MAKJ - Ready"),
                    new Music("JAGGS feat. Sabrina Signs - Hystery"),
                    new Music("FTampa & Sex Room - Lifetime"),
                    new Music("Dimitri Vegas & Like Mike vs. Ummet Ozcan - The Hum"),
                    new Music("Quintino & FTampa - Slammer"),
                    new Music("Showtek feat. We Are Loud & Sonny Wilson - Booyah"),
                    new Music("Ummet Ozcan - SuperWave"),
                    new Music("David Guetta feat. Sam Martin - Lovers On The Sun"),
                    new Music("Ivan Gough & Jebu - Kukatu"),
                    new Music("Dimitri Vegas, Like Mike & VINAI - Louder"),
                    new Music("DVBBS & Joey Dale feat. Delora  - Deja Vu"),
                    new Music("Blasterjaxx & DBSTF  - Beautiful World"),
                    new Music("DallasK - Kaya"),
                    new Music("W&W & Blasterjaxx - Bowser"),
                    new Music("Joey Dale  - Zodiac"),
                    new Music("Hardwell & W&W feat. Fatman Scoop - Don't Stop The Madness"),
                    new Music("BlasterJaxx - Mystica"),
                    new Music("Deorro - Yee"),
                    new Music("Dannic & Sick Individuals  - Blueprint"),
                    new Music("Hardwell & Makj - Countdown"),
                    new Music("Uberjak'd & Reece Low - BLTR"),
                    new Music("Maestro Harrell - Olympus"),
                    new Music("Eric Mendosa & ZEROCOOL - Accelerate"),
                    new Music("Paris Blohm feat. Paul Aiden - Alive"),
                    new Music("Kaaze feat. Nino Lucarelli - Satellites"),
                    new Music("Feenixpawl & Sheco feat. Georgi Kay - Dreams"),
                    new Music("Impulse feat. Josh Dreamer - Stay Until The Sunrise"),
                    new Music("Dannic & Teamworx - NRG"),
                    new Music("Timmy Trumpet  - Freaks"),
                    new Music("Maddix feat. Kris Kiss - Shuttin It Down"),
                    new Music("Sick INdividuals & Jewelz & Sparks - Reaction"),
                    new Music("Sansixto - Stomp"),
                    new Music("Andrew Belize & Timbo - Don't Stop"),
                    new Music("Olly James & Maddix - Invivtus"),
                    new Music("John Christian - The House Is MIne"),
                    new Music("Hardwell & Maddix - Bella Ciao"),
                    new Music("Maurice West - The Kick"),
                    new Music("Holl & Rush - Napoleon"),
                    new Music("Dimitri Vegas & Like Mike vs. Nicky Romero - Here We Go (He Boy, Hey Girl)"),
                    new Music("Martin Garrix - Poison"),
                    new Music("Francois & Louis Benton & Riddim Commission - Only Us"),
                }}
            };
        }

        public HouseTimeTests()
            : base("HouseTime")
        {
            _houseTimeFM = new WeAreOne(base.HttpClient).HouseTime;
        }



        [TestCaseSource(nameof(Tracklist_2018_12_17))]
        public async Task Can_Parse_Old_Tracklist(string date, List<Music> expected)
        {
            base.SetServerResponse(date);


            var actual = await _houseTimeFM.Tracklist();


            base.GenerateStaticTracklist(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
