using Album = Spotify_Casus.Album;
using Songs = Spotify_Casus.Songs;
using Playlists = Spotify_Casus.Playlists;
using Friendlist = Spotify_Casus.Friendlist;


class Program
{
    public static bool paused = true;

    public static void Main(string[] args)
    {
        Console.Title = "Kavel Music Player";


        Album Album = new Album(name: "Ocean Eyes", artist: "Owl city", duration: 895);

        Songs Songs = new Songs(name: "Fireflies", artist: "Owl city", genre: "", duration: 228);

        Playlists Playlists = new Playlists(title: "test", duration: 1856 ,tracks: new List<Songs> { Songs });

        Friendlist Friendlist = new Friendlist();

        while (true)
        {            
            
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Welcome to Kavel Music");
            if (paused == false)
            {
                Console.WriteLine("now playing: " + Songs.Name + " by " + Songs.Artist);
            }
            else
            {
                Console.WriteLine("now playing: nothing");
            }
            //main menu
            Console.WriteLine("*****************");
            Console.WriteLine("1. Album");
            Console.WriteLine("2. Songs");
            Console.WriteLine("3. Playlist");
            Console.WriteLine("4. friendlist");
            Console.WriteLine("5. Play");
            Console.WriteLine("6. Pause");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Choose your option");
            Console.WriteLine("*****************");          
            
            switch(Console.ReadLine())
            {
                // menu for album
                case "1":
                    Console.Clear();
                    Console.WriteLine("*****************");
                    Console.WriteLine("1. Add album to playlist");
                    Console.WriteLine("2. List album");
                    Console.WriteLine("3. Back");
                    Console.WriteLine("Choose your option");
                    Console.WriteLine("*****************");
                    string secondInput = Console.ReadLine();
                    switch (secondInput)
                    {
                        // add a album to playlist
                        case "1":
                            Console.Clear();
                            Console.WriteLine("*****************");
                            Console.WriteLine("Album name");
                            Console.WriteLine("*****************");
                            string albumName = Console.ReadLine();
                            Album.addAlbumToPlaylist(Playlists);
                            Console.WriteLine("*****************");
                            Console.WriteLine("Album added " + albumName + " to playlist");
                            Console.WriteLine("*****************");
                            Console.ReadKey();
                            break;
                        // show a album 
                        case "2":
                            Console.Clear();
                            Console.WriteLine("*****************");
                            Album.PrintAlbum();
                            Console.WriteLine("*****************");

                            break;
                        // back to main menu
                        case "3":
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("*****************");
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("*****************");
                            Console.ReadKey();
                            break;
                    }
                    break;
                case "2":
                    // menu for songs
                    Console.Clear();
                    Console.WriteLine("*****************");
                    Console.WriteLine("1. Add song");
                    Console.WriteLine("2. Remove song");
                    Console.WriteLine("3. Search song");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Choose your option");
                    Console.WriteLine("*****************");                    
                    switch (Console.ReadLine())
                    {
                        // add a song
                        case "1":
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter song name");
                            Console.WriteLine("*****************");
                            string songName = Console.ReadLine();
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter artist name");
                            Console.WriteLine("*****************");
                            string artistName = Console.ReadLine();
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter genre");
                            Console.WriteLine("*****************");
                            string genre = Console.ReadLine();
                            Console.WriteLine("*****************");                            
                            Console.WriteLine("Enter duration in seconds");
                            Console.WriteLine("*****************");
                            int duration = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("*****************");
                            Songs.AddSong(songName, artistName, genre, duration);                          
                            Console.WriteLine("*****************");
                            break;
                        // remove a song
                        case "2":
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter song name");
                            Console.WriteLine("*****************");
                            string songName2 = Console.ReadLine();
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter artist name");
                            Console.WriteLine("*****************");
                            string artistName2 = Console.ReadLine();
                            Console.WriteLine("*****************");
                            Songs.RemoveSong(songName2, artistName2);
                            Console.WriteLine("*****************");
                            break;
                            
                        // search a song
                        case "3":
                            Console.WriteLine("*****************");

                            Console.WriteLine("*****************");
                            break;
                        // back to main menu
                        case "4":
                            Console.Clear();
                            Console.WriteLine(" Going back");
                            
                            break;
                        default:
                            Console.WriteLine("*****************");
                            Console.WriteLine("Wrong input");
                            Console.WriteLine("*****************");
                            break;
                    }
                    break;
                // menu for playlist
                case "3":
                    Console.WriteLine("*****************");
                    Console.WriteLine("*****************");
                    break;
                // menu for friendlist
                case "4":
                    Console.WriteLine("*****************");
                    Console.WriteLine("1. Add friend");
                    Console.WriteLine("2. Remove friend");
                    Console.WriteLine("3. Show list");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Choose your option");
                    Console.WriteLine("*****************");

                    switch (Console.ReadLine())
                    {
                        // add a friend
                        case "1":
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter friend name");
                            Console.WriteLine("*****************");
                            string friendName = Console.ReadLine();
                            Friendlist.AddFriend(friendName);
                            break;
                        // remove a friend
                        case "2":
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter friend name");
                            Console.WriteLine("*****************");
                            string friendName2 = Console.ReadLine();
                            Friendlist.RemoveFriend(friendName2);
                            break;
                        // show a friendlist
                        case "3":
                            Console.WriteLine("*****************");
                            Friendlist.PrintFriends();
                            Console.WriteLine("*****************");
                            break;
                    }
                    break;
                // menu for play
                case "5":
                    Console.WriteLine("*****************");
                    Console.WriteLine("1. Play a song");
                    Console.WriteLine("2. Play a Playlist");
                    Console.WriteLine("3. Play a Album");
                    Console.WriteLine("*****************");
                    switch (Console.ReadLine())
                    {
                        // play a song
                        case "1":
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter song name");
                            Console.WriteLine("*****************");
                            string songName3 = Console.ReadLine();
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter artist name");
                            Console.WriteLine("*****************");
                            string artistName3 = Console.ReadLine();
                            Songs.Play(songName3);
                            Console.WriteLine("*****************");
                            break;
                        // play a playlist
                        case "2":
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter playlist name");
                            Console.WriteLine("*****************");
                            string playlistName = Console.ReadLine();
                            Console.WriteLine("*****************");
                            Playlists.Play(playlistName);
                            Console.WriteLine("*****************");
                            break;
                        // play a album
                        case "3":
                            Console.WriteLine("*****************");
                            Console.WriteLine("Enter album name");
                            Console.WriteLine("*****************");                            
                            string albumName2 = Console.ReadLine();
                            Console.WriteLine("*****************");
                            Album.Play(albumName2);
                            Console.WriteLine("*****************");
                            break;
                        default:
                            Console.WriteLine("*****************");
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("*****************");
                            break;
                    }
                    break;
                   // pausing music
                case "6":
                    Console.WriteLine("*****************");
                    Console.WriteLine("Pause");
                    Console.WriteLine("*****************");
                    paused = true;
                    break;
                // exit the program
                
                case "7":
                    Console.WriteLine("Quiting");
                    Console.WriteLine("thank you for using Kavel Music");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    
                    break;
            }
        }
    }
}