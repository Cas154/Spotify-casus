using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
