using NUnit.Framework;
using PoLaKoSz.WeAreOne.EndPoints;
using PoLaKoSz.WeAreOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoLaKoSz.WeAreOne.Tests.Integration.EndPoints
{
    class TranceBaseTests : TestClassBase
    {
        private static readonly object[] Tracklist_2018_12_17;
        private readonly RadioStation _tranceBaseFM;



        static TranceBaseTests()
        {
            Tracklist_2018_12_17 = new[]
            {
                new object[] { "2018_12_17", new List<Music>()
                {
                    new Music("James Dymond - Black Mirror"),
                    new Music("Leuchtturm inkl. Sandberg - Leuchtturm"),
                    new Music("Will Atkinson - Seventh Heaven"),
                    new Music("Ronski Speed & Sebastian Sand - Sole Survivor"),
                    new Music("Ultimate - Adam's Peak"),
                    new Music("Ana Criado, Steve Allen and Solis & Sean Truby - Frozen River"),
                    new Music("Omnia feat. Everything By Electricity - Bones"),
                    new Music("Simon Patterson - Taxi"),
                    new Music("Solis & Sean Truby with Cari - Easy Way Out"),
                    new Music("Above & Beyond - Anjunabeach"),
                    new Music("Daniel Kandi & Robert Nickson - Liberate"),
                    new Music("Simon Patterson - Solo"),
                    new Music("Mark Otten - Mushroom Therapy"),
                    new Music("Estiva & Justin Oh feat. Abby Rae - Reach For The Sky"),
                    new Music("Adam Ellis & Jo Cartwright - Broken"),
                    new Music("Mike Foyle - Pandora"),
                    new Music("Armin van Buuren - Lifting You Higher (ASOT 900 Anthem)"),
                    new Music("Josh Gabriel pres. Winter Kills - Hot As Hades"),
                    new Music("Armin van Buuren feat. Sam Martin - Wild Wild Son"),
                    new Music("The Avengers - Yugen"),
                    new Music("Soundlift - Empty Night Street"),
                    new Music("Cosmic Gate - Exploration Of Space"),
                    new Music("Alex M.O.R.P.H. & Woody Van Eyden feat. Michelle Citrin - Turn It On"),
                    new Music("Filo & Peri feat. Eric Lumiere - Shine On"),
                    new Music("Aly & Fila with Philippe El Sisi & Omar Sherif - A World Beyond (FSOE550 Anthem)"),
                    new Music("Bryn Liedl feat. Bethany Marie - Statues"),
                    new Music("Sean Tyas - Lift"),
                    new Music("Paul Thomas feat. Katherine Amy - Sweet Harmony"),
                    new Music("Sunset & Alpha Force feat. Robin Vane - With You"),
                    new Music("Pedro Del Mar feat. Emma Nelson - Feel"),
                    new Music("Solarstone and JES - Like A Waterfall"),
                    new Music("Stine Grove - This World Is Full of Goodbyes 2018"),
                    new Music("Somna & Cari - My Home"),
                    new Music("Alex Sonata feat. Dean Chalmers - My Heart"),
                    new Music("Factor B feat. Cat Martin - White Rooms"),
                    new Music("Roger Shah pres. LeiLani - Eternal Time"),
                    new Music("Ben Nicky - Driven"),
                    new Music("Medina - You And I"),
                    new Music("W&W - Mainstage"),
                    new Music("Filo & Peri feat. Aruna - Ashley"),
                    new Music("Paul van Dyk - Time Of Our Lives"),
                    new Music("Cold Blue - Rush"),
                    new Music("Maryn feat. Susie Ledge - Shine On Me"),
                    new Music("Standerwick - I've Been Thinking About You"),
                    new Music("Madwave & Exouler - Miracle"),
                    new Music("Dash Berlin feat. Bo Bruce - Coming Home"),
                    new Music("HÃLY WATERS - Amsterdam"),
                    new Music("Lee Osborne & Allen Watts - Telepathy"),
                    new Music("Richard Durand & Christina Novelli - The Air I Breathe"),
                    new Music("Matt Cerf & Tomac feat. Jaren - Who I Am"),
                }}
            };
        }

        public TranceBaseTests()
            : base("TranceBase")
        {
            _tranceBaseFM = new WeAreOne(base.HttpClient).TranceBase;
        }



        [TestCaseSource(nameof(Tracklist_2018_12_17))]
        public async Task Can_Parse_Old_Tracklist(string date, List<Music> expected)
        {
            base.SetServerResponse(date);


            var actual = await _tranceBaseFM.Tracklist();


            base.GenerateStaticTracklist(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
