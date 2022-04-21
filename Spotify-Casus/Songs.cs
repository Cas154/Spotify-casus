namespace Spotify_Casus
{
    internal class Songs
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


    }
}
