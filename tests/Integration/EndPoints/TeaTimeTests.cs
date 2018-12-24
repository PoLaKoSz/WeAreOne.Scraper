using NUnit.Framework;
using PoLaKoSz.WeAreOne.EndPoints;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.Tests.Integration.EndPoints
{
    class TeaTimeTests : TestClassBase
    {
        private static readonly object[] Tracklist_2018_12_17;
        private readonly RadioStation _teaTimeFM;



        static TeaTimeTests()
        {
            Tracklist_2018_12_17 = new[]
            {
                new object[] { "2018_12_17", new List<Music>()
                {
                    new Music("Dougal & Gammer - Fires In The Sky (Face Lift)"),
                    new Music("Dougal & Gammer - Trust In Me"),
                    new Music("Chainsmokers - Closer"),
                    new Music("Ember Island - Umbrella"),
                    new Music("Fox Stevenson - Miss You"),
                    new Music("W&W & Darren Styles feat. Giin - Long Way Down"),
                    new Music("Darren Styles - Partystarter"),
                    new Music("Gammer & Dougal - Blow This"),
                    new Music("Darren Styles & Gammer & Dougal - Burning Up"),
                    new Music("Sander van Doorn, Martin Garrix, DVBBS feat. Aleesia  - Gold Skies"),
                    new Music("Darren Styles & Gammer - You & I"),
                    new Music("Jakka B & Summa Jae - You Show Me"),
                    new Music("Stu Infinity - No Stoppin' Us Now"),
                    new Music("Dougal & Gammer feat. JennaÂ  - When I Close My Eyes"),
                    new Music("Armin van Buuren feat. Laura Jansen - Sound Of The Drums"),
                    new Music("Darren Styles & Dougal Feat. Jacob Wellfair - Home"),
                    new Music("Gammer - Beam Of Light"),
                    new Music("Sander van Doorn, Martin Garrix, DVBBS feat. Aleesia  - Gold Skies"),
                    new Music("Clear Vu - Never 2 Late"),
                    new Music("Darren Styles - Satellite"),
                    new Music("Dougal & Gammer - Stay Young"),
                    new Music("Gammer - The Drop"),
                    new Music("Darren Styles & Gammer & Dougal - Burning Up"),
                    new Music("Darren Styles - The Dragon"),
                    new Music("Fox Stevenson - Miss You"),
                    new Music("Porter Robinson - Language"),
                    new Music("Stonebank Feat. EMEL - Stronger"),
                    new Music("Ryan Kore Feat. Farisha - Take Me There"),
                    new Music("Olly P. - I Want You"),
                    new Music("Jekyll & Clarkey - Open Your Eyes"),
                    new Music("Dougal & Gammer - Your One"),
                    new Music("Gregor le DahL - Till The End"),
                    new Music("Outforce - Silhouettes"),
                    new Music("Klubfiller - Ain't No Stopping Us Now"),
                    new Music("Daniel Seven & Gregor le DahL - My World"),
                    new Music("Alex Prospect - Watch Me Run"),
                    new Music("Outforce & Hartshorn feat. MC Riddle - Keep It Mello"),
                    new Music("Technikore feat. Nathalie - Yours Tonight"),
                    new Music("Alex Prospect & Spyro - Up 2 No Good"),
                    new Music("Katy Perry - Teenage Dream"),
                    new Music("Anon - Byrne"),
                    new Music("S3RL feat. TamikaÂ  - Mr. Vain"),
                    new Music("Yolanda Be Cool & DCUP - We No Speak Americano"),
                    new Music("Jessie J feat. David Guetta - Laserlight"),
                    new Music("Cascada - What Do You Want From Me?"),
                    new Music("Sebastian Ingrosso & Tommy Trash feat. John Martin - Reload"),
                    new Music("RedMoon feat. Meron Ryan - Heavyweight"),
                    new Music("Re-Con  - Fuel To Fire"),
                    new Music("Pendulum - The Island"),
                    new Music("Nicholson feat. Niki Mak - To The Flame (Charlotte's Theme)"),
                }}
            };
        }

        public TeaTimeTests()
            : base("TeaTime")
        {
            _teaTimeFM = new WeAreOne(base.HttpClient).TeaTime;
        }



        [TestCaseSource(nameof(Tracklist_2018_12_17))]
        public async Task Can_Parse_Old_Tracklist(string date, List<Music> expected)
        {
            base.SetServerResponse(date);


            var actual = await _teaTimeFM.Tracklist();


            base.GenerateStaticTracklist(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
