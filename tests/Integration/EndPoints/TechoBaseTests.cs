using NUnit.Framework;
using PoLaKoSz.WeAreOne.EndPoints;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.Tests.Integration.EndPoints
{
    class TechoBaseTests : TestClassBase
    {
        private static readonly object[] Tracklist_2018_12_17;
        private readonly IRadioStation _techoBaseFM;



        static TechoBaseTests()
        {
            Tracklist_2018_12_17 = new[]
            {
                new object[] { "2018_12_17", new List<Music>()
                {
                    new Music("John Snow - Smile"),
                    new Music("De-Liver feat. Dee Dee - Give Me A Sign"),
                    new Music("Miss Diva - Love Me"),
                    new Music("Beat Bangerz - Doop (Re-Washed)"),
                    new Music("Commercial Club Crew - La Isla Bonita"),
                    new Music("Dual Playaz - Another Day"),
                    new Music("Miradey - Can't get Enough"),
                    new Music("DJ THT - Yesterday"),
                    new Music("Eric Prince - Poltergeist"),
                    new Music("Projekt Black - Freaks"),
                    new Music("Empyre One & Enerdizer - My Radio"),
                    new Music("DJ Cap feat. Maria B. - You Are My Only One"),
                    new Music("Dan Winter & Ryan T. feat. Dee Dee - Yamandana"),
                    new Music("Sonictunez - We Got The Beat"),
                    new Music("Alari & Vane - You'll Be Mine"),
                    new Music("Bangbros - Children"),
                    new Music("Belmond & Parker - On the Move"),
                    new Music("DJ Shog - Another World"),
                    new Music("Aquagen feat. Rozalla - Everybody's Free"),
                    new Music("Jan Wayne - More Than A Feeling"),
                    new Music("Inspiration Vibes - Get Wicked"),
                    new Music("Van Nuys - Wonderful World"),
                    new Music("Chris - Campell"),
                    new Music("Bangbros - I Engineer"),
                    new Music("Mario Lopez - You Came"),
                    new Music("Prezioso & Marvin - Survivial"),
                    new Music("Liz Kay - When Love Becomes A Lie"),
                    new Music("Liquid Spill Meets Pinkville - Maria Magdalena"),
                    new Music("Akira - I Dream"),
                    new Music("Deep.Spirit feat. Kathy - No Cover Song"),
                    new Music("Liz Kay - Castles In The Sky"),
                    new Music("Lazard - I Am Alive!"),
                    new Music("Kim Leoni - Medicine"),
                    new Music("Kate Ryan - Ella Ella L'a"),
                    new Music("Jordan - What If"),
                    new Music("Plasdance feat. Jai Matt - Wondering"),
                    new Music("Mikosch2K - Alone"),
                    new Music("Sunshine DJ - Hold Me"),
                    new Music("Ste Ingham feat. Livia McKee - Better Off Alone"),
                    new Music("Ryan T. & Dan Winter feat. Damae - You And Me"),
                    new Music("Sascha Nell feat. Addie Nicole - Never Say Never"),
                    new Music("Ziggy X - ZanzaX"),
                    new Music("Topmodelz - Rain In May"),
                    new Music("Darius & Finlay feat. Isi Glück - Was Immer Bleibt"),
                    new Music("Killa Squad - The Monk Song"),
                    new Music("BloodDropz! - She"),
                    new Music("Bulljay feat. Mr Shammi - Blaze It"),
                    new Music("Pulsedriver & Tiscore - One To Make Her Happy"),
                    new Music("Miradey - Sayonara"),
                    new Music("Mis Teria - Shout Out To My Ex"),
                }}
            };
        }

        public TechoBaseTests()
            : base("TechnoBase")
        {
            _techoBaseFM = new WeAreOne(base.HttpClient).TechoBase;
        }



        [TestCaseSource(nameof(Tracklist_2018_12_17))]
        public async Task Can_Parse_Old_Tracklist(string date, List<Music> expected)
        {
            base.SetServerResponse(date);


            var actual = await _techoBaseFM.Tracklist();


            base.GenerateStaticTracklist(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
