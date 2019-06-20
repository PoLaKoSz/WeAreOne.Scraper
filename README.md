# WeAreOne.Scraper

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c2d3a55cef8646bfbb644280011b88ec)](https://www.codacy.com/app/PoLaKoSz/WeAreOne.Scraper?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=PoLaKoSz/WeAreOne.Scraper&amp;utm_campaign=Badge_Grade)
[![Build Status](https://travis-ci.com/PoLaKoSz/WeAreOne.Scraper.svg?branch=master)](https://travis-ci.com/PoLaKoSz/WeAreOne.Scraper)
[![Latest Stable Version](https://img.shields.io/github/tag/PoLaKoSz/WeAreOne.Scraper.svg?label=stable)](../../releases)
[![Total Downloads](https://img.shields.io/nuget/dt/PoLaKoSz.WeAreOne.Scraper.svg?style=plastic)](https://www.nuget.org/packages/PoLaKoSz.WeAreOne.Scraper)
[![License](https://img.shields.io/github/license/PoLaKoSz/WeAreOne.Scraper.svg?style=plastic)](LICENSE)

WeAreOne is a radio station family hosted in Germany. Probably the most famous radio station is the TechnoBase.FM, but there are 6 more:
ClubTime.FM, CoreTime.FM, HardBase.FM, HouseTime.FM, TeaTime.FM and TranceBase.FM. With this library You can access all 7 radio's tracklist. 

## Install
via [NuGet](https://www.nuget.org/packages/PoLaKoSz.WeAreOne.Scraper/)
```` shell
PM > Install-Package PoLaKoSz.WeAreOne.Scraper
````

## Quick start

That's all You need and can use with this library. Copied from the sample project:

```` c#
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
````
