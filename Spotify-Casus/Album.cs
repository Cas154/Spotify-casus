namespace Spotify_Casus
{
    internal class Album
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        List<Songs> ListSongs = new List<Songs>();

        public Album(string name, string artist, int duration)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
        }

        public void AddSong(Songs song)
        {
            ListSongs.Add(song);
        }

        public void PrintAlbum()
        {
            Console.WriteLine("Album: " + Name);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Duration: " + Duration);
            Console.WriteLine("Songs: ");
            foreach (Songs song in ListSongs)
            {
                Console.WriteLine(song.Name);
            }
        }
        public void addAlbumToPlaylist(Playlists playlist)
        {
            foreach (Songs song in ListSongs)
            {
                playlist.addTrack(song);
            }
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
            Console.WriteLine("Stopped");
            System.Environment.Exit(0);
        }


    }
}
