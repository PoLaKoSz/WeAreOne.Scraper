using PoLaKoSz.WeAreOne;
using PoLaKoSz.WeAreOne.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var weAreOne = new WeAreOne();

            var tracklist = weAreOne.TechoBase.Tracklist().GetAwaiter().GetResult();
            DisplayTracklist(tracklist, "TechoBase");


            tracklist = weAreOne.HouseTime.Tracklist().GetAwaiter().GetResult();
            DisplayTracklist(tracklist, "HouseTime");


            tracklist = weAreOne.HardBase.Tracklist().GetAwaiter().GetResult();
            DisplayTracklist(tracklist, "HardBase");


            tracklist = weAreOne.TranceBase.Tracklist().GetAwaiter().GetResult();
            DisplayTracklist(tracklist, "TranceBase");


            tracklist = weAreOne.CoreTime.Tracklist().GetAwaiter().GetResult();
            DisplayTracklist(tracklist, "CoreTime");


            tracklist = weAreOne.ClubTime.Tracklist().GetAwaiter().GetResult();
            DisplayTracklist(tracklist, "ClubTime");


            tracklist = weAreOne.TeaTime.Tracklist().GetAwaiter().GetResult();
            DisplayTracklist(tracklist, "TeaTime");

            Console.Read();
        }

        private static void DisplayTracklist(List<Music> tracklist, string name)
        {
            Console.WriteLine(name);

            for (int i = 0; i < tracklist.Count; i++)
            {
                var track = tracklist[i];

                Console.WriteLine($"\t#{i,3}\t{track.Name}");
            }

            Console.WriteLine("\n");
        }
    }
}
