namespace Spotify_Casus
{
    internal class Vriendenlijst
    {
        public List<Vriend> Vrienden { get; set; }
        public Vriendenlijst()
        {
            Vrienden = new List<Vriend>();
        }
        public void AddVriend(Vriend vriend)
        {
            Vrienden.Add(vriend);
        }
        public void RemoveVriend(Vriend vriend)
        {
            Vrienden.Remove(vriend);
        }
        public void RemoveVriend(string naam)
        {
            Vrienden.Remove(Vrienden.Find(x => x.Naam == naam));
        }
        public Vriend FindVriend(string naam)
        {
            return Vrienden.Find(x => x.Naam == naam);
        }
        public void PrintVrienden()
        {
            foreach (Vriend vriend in Vrienden)
            {
                Console.WriteLine(vriend.Naam);
            }
        }
    }

    public class Vriend
    {
        public string Naam { get; internal set; }
        public string getName()
        {
            return Naam;
        }
    }
}
