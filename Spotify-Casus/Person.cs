using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Casus
{
    internal class Person
    {

        public string Name { get; set; }
        public List<Playlists> playlists = new List<Playlists>();
        public Vriendenlijst vriendenlijst = new Vriendenlijst();

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


    }
}
