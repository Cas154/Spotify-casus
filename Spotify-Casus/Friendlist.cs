namespace Spotify_Casus
{
    internal class Friendlist
    {
        public List<Vriend> Vrienden { get; set; } = new List<Vriend>();
        public Friendlist()
        {
            Vrienden = new List<Vriend>();
        }
        public void AddFriend(string vriend)
        {
            foreach (Vriend v in Vrienden)
            {
                if (v.Naam == vriend)
                {
                    Console.WriteLine("Vriend is al toegevoegd");
                    Thread.Sleep(2300);
                    return;
                }                
            }
            Vrienden.Add(new Vriend(vriend));

        }
        public void RemoveFriend(string vriend)
        {
            foreach (Vriend v in Vrienden)
            {
                if (v.Naam == vriend)
                {
                    Vrienden.Remove(v);
                    return;
                }
            }      
        }
        public void PrintFriends()
        {
            foreach (Vriend v in Vrienden)
            {
                Console.WriteLine("your Friends:");
                Console.WriteLine(v.Naam);
            }
        }
    }

    public class Vriend
    {
        private string vriend;

        public Vriend(string vriend)
        {
            Naam = vriend;
        }

        public string Naam { get; internal set; }
        public string getName()
        {
            return Naam;
        }
    }
}
