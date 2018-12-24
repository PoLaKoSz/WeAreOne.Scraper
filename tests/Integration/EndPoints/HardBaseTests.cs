using NUnit.Framework;
using PoLaKoSz.WeAreOne.EndPoints;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.Tests.Integration.EndPoints
{
    class HardBaseTests : TestClassBase
    {
        private static readonly object[] Tracklist_2018_12_17;
        private readonly RadioStation _hardBaseFM;



        static HardBaseTests()
        {
            Tracklist_2018_12_17 = new[]
            {
                new object[] { "2018_12_17", new List<Music>()
                {
                    new Music("D-Fence & Deadly Guns - Wall Of Bass"),
                    new Music("Krowdexx - Moshpit"),
                    new Music("Radical Redemption & D-Sturb - Testarossa"),
                    new Music("Malice & Unresolved & Project Core - Demolition"),
                    new Music("Malice - Brutalized"),
                    new Music("Rebelion - Corruption"),
                    new Music("Delete - V1P"),
                    new Music("Riot Shift - Boundaries"),
                    new Music("Endymion - Gladiator"),
                    new Music("Act Of Rage feat. MC Jeff - Subject Hostile (Official Shockerz 2018 Anthem)"),
                    new Music("D-Sturb & Malice - Drop 'Em Down"),
                    new Music("Frequencerz - Earthquake"),
                    new Music("Degos & Re-Done - Risk The Dark"),
                    new Music("Myst - Where I Shine"),
                    new Music("Frequencerz - Alright"),
                    new Music("Phuture Noize & B-Front - The Solution"),
                    new Music("Frequencerz - Ballistic"),
                    new Music("RVAGE feat. Elyn - Planet 10 (Official Indicator Anthem 2018"),
                    new Music("The Pitcher feat. Sam LeMay - Music In Me"),
                    new Music("KELTEK - Dark Sun"),
                    new Music("Deepack - For The People"),
                    new Music("Cyber - MF BASS"),
                    new Music("Project One - Life Beyond Earth"),
                    new Music("Max Enforcer & ANDY SVGE feat. Heavynn - Deep'r"),
                    new Music("Headhunterz - Say My Name"),
                    new Music("Technoboy, Tuneboy & Isaac - Digital Nation"),
                    new Music("Headhunterz - Rock Civilization"),
                    new Music("Coone & Wildstylez - Here I Come"),
                    new Music("Crystal Lake - Message From Space"),
                    new Music("Psyko Punkz & KELTEK - The Apex"),
                    new Music("Atmozfears & Devin Wild feat. David Spekter - Breathe"),
                    new Music("Wasted Penguinz - Evergreen"),
                    new Music("D-Block & S-Te-Fan - Gave U My Love"),
                    new Music("E-Force - Seven"),
                    new Music("Krowdexx - Smack Ya Face"),
                    new Music("Unkind - F#ckin' With The Best"),
                    new Music("Rooler - Yes"),
                    new Music("N-Vitral - Crispy Bassdrum"),
                    new Music("Rebelion - Keep It Fuckin' Poppin'"),
                    new Music("Zany & Mental Theo - Tonight"),
                    new Music("Adaro & B-Front feat. Dawnfire - Touch A Star"),
                    new Music("Sub Zero Project - The Game Changer (Qlimax 2018 Anthem)"),
                    new Music("The Prophet - Listen To Your Heart"),
                    new Music("Wasted Penguinz - Make It One Day"),
                    new Music("ANDY SVGE feat. Mark Vayne - Better Off Alone"),
                }}
            };
        }

        public HardBaseTests()
            : base("HardBase")
        {
            _hardBaseFM = new WeAreOne(base.HttpClient).HardBase;
        }



        [TestCaseSource(nameof(Tracklist_2018_12_17))]
        public async Task Can_Parse_Old_Tracklist(string date, List<Music> expected)
        {
            base.SetServerResponse(date);


            var actual = await _hardBaseFM.Tracklist();


            base.GenerateStaticTracklist(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
