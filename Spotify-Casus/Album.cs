namespace Spotify_Casus
{
    internal class Album
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        List<Songs> songs = new List<Songs>();
        public Album(string name, string artist, int duration, List<Songs> songs)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
            songs = songs;
        }

        public Album(string name, string artist, int duration, string songs)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
            songs = songs;
        }

        public void PrintAlbum()
        {
            Console.WriteLine("Album: " + Name + " by " + Artist + " with " + Duration + " minutes of songs.");
            Console.WriteLine("Songs: ");
            foreach (Songs song in songs)
            {               
                Console.WriteLine(song.Name);
            }
        }
    }
}
