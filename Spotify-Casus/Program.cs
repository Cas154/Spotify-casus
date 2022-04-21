using Spotify_Casus;
using Album = Spotify_Casus.Album;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        Album album = new Album(name: "Ocean Eyes", artist: "Owl city", duration: 895, songs: "Fireflies") ;

        Songs Songs = new Songs("Fireflies", "Owl city", "", 228);

        Console.WriteLine(album.Name);
        Console.WriteLine(" ");
        Console.WriteLine(Songs.ToString());
    }
}
