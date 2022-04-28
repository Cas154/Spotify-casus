namespace Spotify_Casus
{
    internal class Songs : Player
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }

        public Songs(string name, string artist, string genre, int duration)
        {
            Name = name;
            Artist = artist;
            Genre = genre;
            Duration = duration;
        }
        public override string ToString()
        {
            return $"{Name} - {Artist} - {Genre} - {Duration}";
        }
        public void AddSong(string songName, string artistName,string genreName,int duration)
        {
            Songs song = new Songs(songName, artistName, genreName, duration);
            Console.WriteLine(song);
            Console.WriteLine("Song added");
        }
        public void RemoveSong(string songName, string artistName)
        {
            if (Name == songName && Artist == artistName)
            {
                Console.WriteLine("Song removed");
            }
            else
            {
                Console.WriteLine("Song not found");
            }
        }
        public void Play(string song)
        {
            Console.WriteLine("Playing " + song);
            Program.paused = false;
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
