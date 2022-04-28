namespace Spotify_Casus
{
    internal interface Player
    {
        void Play(string song);
        void Pause();
        void skip();
        void Stop();
    }
}
