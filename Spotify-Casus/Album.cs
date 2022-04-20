using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Casus
{
    internal class Album
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Duration { get; set; }
        List<Songs> songs = new List<Songs>();
        public Album(string name, string artist, string duration)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
        }

        public void PrintAlbum()
        {
            Console.WriteLine("Album: " + Name);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Duration: " + Duration);
            Console.WriteLine("Songs: ");
            foreach (Songs song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
