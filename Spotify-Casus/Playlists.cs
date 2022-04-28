namespace Spotify_Casus
{
    internal class Playlists : Class1, Player 
    {



        public List<Songs> Tracks { get; set; } = new List<Songs>();
        public string Name { get; }
        public string Songs { get; }
        public string Album { get; }

        public void addTrack(Songs track)
        {
            Tracks.Add(track);
        }
        public void removeTrack(Songs track)
        {
            Tracks.Remove(track);
        }

        public Playlists(string title, int duration, List<Songs> tracks)
        {
            Title = title;
            Duration = duration;
            Tracks = tracks;
        }

   //     public Playlists(string name, string songs, string album)
   //     {
//Name = name;
     //       Songs = songs;
   //         Album = album;
     //   }

        public string getName()
        {
            return Title;
        }

        public void Play(string song)
        {
            Console.WriteLine("Playing " + song);
        }

        public void Pause()
        {
            Console.WriteLine("Paused");
        }

        public void skip()
        {
            Console.WriteLine("Skipped");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
