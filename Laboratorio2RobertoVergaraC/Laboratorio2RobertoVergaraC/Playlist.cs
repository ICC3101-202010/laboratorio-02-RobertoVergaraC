using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2RobertoVergaraC
{
    class Playlist
    {
        private string name;
        private List<Cancion> playlist;

        public Playlist(string name, List<Cancion> playlist)
        {
            this.name = name;
            this.playlist = playlist;
        }

        public void InformacionPlaylist()
        {
            Console.WriteLine("El nombre de la Playlist es: " + this.name + "\n");
            for (int i = 0; i < this.playlist.Count; i++)
            {
                Console.WriteLine("\n" + this.playlist[i].Informacion() + "\n");
            }
        }
    }
}
