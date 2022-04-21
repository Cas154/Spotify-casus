namespace Spotify_Casus
{
    internal class Playlists : Class1, Player 
    {
    
        
        
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
        public string getName()
        {
            return Title;
        }

        public void Play(string song)
        {
            Console.WriteLine("Playing " + song);
            throw new NotImplementedException();
        }

        public void Pause()
        {
            Console.WriteLine("Paused");
            throw new NotImplementedException();
        }

        public void skip()
        {
            Console.WriteLine("Skipped");
            
            throw new NotImplementedException();
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
            System.Environment.Exit(0);
            throw new NotImplementedException();
        }
    }
}
