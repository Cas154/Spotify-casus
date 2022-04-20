using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Casus
{
    internal class Playlists
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public List<string> Tracks { get; set; }

        public void addTrack(string track)
        {
            Tracks.Add(track);
        }
        public void removeTrack(string track)
        {
            Tracks.Remove(track);
        }

        public Playlists(string title, int duration, List<string> tracks)
        {
            Title = title;
            Duration = duration;
            Tracks = tracks;
        }

    }
}
