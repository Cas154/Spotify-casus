namespace Spotify_Casus
{
    internal class Person
    {

        public string Name { get; set; }
        public List<Playlists> playlists = new List<Playlists>();
        public Friendlist vriendenlijst = new Friendlist();

        public Person(string name)
        {
            Name = name;
        }
        public void printVriendenlijst()
        {
            Console.WriteLine("Vriendenlijst van " + Name);
            foreach (Vriend p in vriendenlijst.Vrienden)
            {
                Console.WriteLine(p.getName());

            }
            
        }
        public void printPlaylists()
        {
            Console.WriteLine("Playlists van " + Name);
            foreach (Playlists p in playlists)
            {
                Console.WriteLine(p.getName());

            }
        }


    }
}
