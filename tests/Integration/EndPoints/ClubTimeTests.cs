using NUnit.Framework;
using PoLaKoSz.WeAreOne.EndPoints;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.Tests.Integration.EndPoints
{
    class ClubTimeTests : TestClassBase
    {
        private static readonly object[] Tracklist_2018_12_17;
        private readonly RadioStation _clubTimeFM;



        static ClubTimeTests()
        {
            Tracklist_2018_12_17 = new[]
            {
                new object[] { "2018_12_17", new List<Music>()
                {
                    new Music("Gene Farris - We Like The Deep"),
                    new Music("Dennis Ferrer - How Do I Let Go"),
                    new Music("Davi - The Time Has Come"),
                    new Music("Transcode - Encounters"),
                    new Music("Project89 - Somebody"),
                    new Music("AFFKT - Pentode"),
                    new Music("Tom Zeta - Absorption"),
                    new Music("Sebastien Leger - Hypnotized"),
                    new Music("Raul Facio - Cid Cid"),
                    new Music("Mark Reeve - New Path"),
                    new Music("DJ Freespirit - In My Key"),
                    new Music("Raskal - A Future Beyond"),
                    new Music("Modium - Baila"),
                    new Music("Uppercut - Inside Me"),
                    new Music("D.O.N.S. feat Alexandra Prince - How Will I Know"),
                    new Music("Sugar & Daddy - Life Together"),
                    new Music("Romanthony - Too Long"),
                    new Music("Martin Wright - Big It Up"),
                    new Music("Modium - Mind, Body And Soul"),
                    new Music("Marc Vedo - Truth"),
                    new Music("Kid Shakers - La Bota"),
                    new Music("Club In Bewegung - Clubroom Girl"),
                    new Music("Helmut Wintermantel - Clubtour De Berlin"),
                    new Music("Albers Kunhart - Let It Go"),
                    new Music("Gabriel Creole - Chords Running"),
                    new Music("Mark Marsland - Up & Down"),
                    new Music("Crazy Krauts - Deeper To The Underground"),
                    new Music("Di Mi Do - On The Move"),
                    new Music("Blueeyes & Waldschrat - Elements"),
                    new Music("yukosamo - Late-Night-Bar"),
                    new Music("Berlin Minimal - SchÃ¶nefelder Weisen"),
                    new Music("Peter Pressure - Need To Change"),
                    new Music("Albers Kunhart - Analog Beat"),
                    new Music("Michael Doerlitz - Genetic Code"),
                    new Music("Ryan Wald - Do Ya Wanna Dance"),
                    new Music("Ferdinant Dreyssig & Marvin Hey - Cour De La Nuit"),
                    new Music("Left Noize - Evolution"),
                    new Music("DIF - Ghostrider"),
                    new Music("DJ Navigare - Core"),
                    new Music("Daniel Slam - Cum Machine"),
                    new Music("Wasscass - White City"),
                    new Music("Dennis Smile - Jack The Ripper"),
                    new Music("Cyril Picard, Greenwolve - Lets Party"),
                    new Music("Daft - Ear Pressure"),
                    new Music("Angy Kore - Kerobba"),
                    new Music("Vini Vici & Timmy Trumpet Ft. Symphonic - 100"),
                    new Music("Pan-Pot - Solace"),
                    new Music("Kenji Kawai - Ghost in the Shell"),
                    new Music("Steve Shaden - Bunker"),
                    new Music("Jon Rundell - Solitude"),
                }}
            };
        }

        public ClubTimeTests()
            : base("ClubTime")
        {
            _clubTimeFM = new WeAreOne(base.HttpClient).ClubTime;
        }



        [TestCaseSource(nameof(Tracklist_2018_12_17))]
        public async Task Can_Parse_Old_Tracklist(string date, List<Music> expected)
        {
            base.SetServerResponse(date);


            var actual = await _clubTimeFM.Tracklist();


            base.GenerateStaticTracklist(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
