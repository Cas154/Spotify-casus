using Album = Spotify_Casus.Album;
using Songs = Spotify_Casus.Songs;

class Program
{


    static void Main(string[] args)
    {
        Console.Title = "Kavel Play";
        bool mainMenu = true;

        Album Album = new Album(name: "Ocean Eyes", artist: "Owl city", duration: 895, songs: "Fireflies");

        Songs Songs = new Songs(name: "Fireflies", artist: "Owl city", genre: "", duration: 228);
        while (mainMenu == true)
        {
            //main menu
            Console.Clear();
            Console.WriteLine("Welcome to Kavel Play");
            Console.WriteLine("*****************");
            Console.WriteLine("1. Album");
            Console.WriteLine("2. Songs");
            Console.WriteLine("3. Playlist");
            Console.WriteLine("4. Playlist");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Choose your option");
            Console.WriteLine("*****************");

            string firstInput = Console.ReadLine();

            switch (firstInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("*****************");
                    Console.WriteLine("1. Add album");
                    Console.WriteLine("2. Remove album");
                    Console.WriteLine("3. List album");
                    Console.WriteLine("4. Back");
                    Console.WriteLine("Choose your option");
                    Console.WriteLine("*****************");
                    return;
                case "2":
                    Console.Clear();
                    Console.WriteLine("*****************");
                    Console.WriteLine("1. Add song");
                    Console.WriteLine("2. Remove song");
                    Console.WriteLine("3. Search song");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine("Choose your option");
                    Console.WriteLine("*****************");
                    string secondInput = Console.ReadLine();
                    switch (secondInput)
                    {
                        case "1":
                            Console.WriteLine("*****************");

                            Console.WriteLine("*****************");
                            break;
                        case "2":
                            Console.WriteLine("*****************");

                            Console.WriteLine("*****************");
                            break;
                        case "3":
                            Console.WriteLine("*****************");

                            Console.WriteLine("*****************");
                            break;
                        case "4":
                            Console.WriteLine("Quit");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                    return;
                case "3":
                    Console.WriteLine("*****************");
                    Console.WriteLine("*****************");
                    break;
                case "4":
                    Console.WriteLine("*****************");
                    Console.WriteLine("*****************");
                    break;
                case "5":
                    Console.WriteLine("Quit");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    mainMenu = true;
                    break;
            }
        }
    }
}