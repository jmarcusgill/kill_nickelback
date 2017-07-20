using System;
using System.Collections.Generic;


namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List <(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string, string)> playList = new HashSet<(string, string)>();
            playList.Add(("Photograph", "NickelBack"));
            playList.Add(("Rockstar", "NickelBack"));
            playList.Add(("Animals", "NickelBack"));
            playList.Add(("Someday", "NickelBack"));
            playList.Add(("Dorothy", "MeWithoutYou"));
            playList.Add(("The Weight", "Thrice"));
            playList.Add(("XXX", "Kendrick Lamar"));
            playList.Add(("Hero", "NickelBack"));
            playList.Add(("Pin", "Yeah Yeah Yeahs"));


            foreach ((string, string) song in playList)
            {
                if (song.Item2 != "NickelBack")
                {
                    goodSongs.Add(song);
                } 
            }

             

            foreach ((string, string) song in goodSongs)
            {
                Console.WriteLine($"{song.Item1} by {song.Item2}");
            }


        }

    }
}
