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

        public string Name { get => name; set => name = value; }

        public Playlist(string name, List<Cancion> playlist)
        {
            this.Name = name;
            this.playlist = playlist;
        }

        public void InformacionPlaylist()
        {
            Console.WriteLine("El nombre de la Playlist es: " + this.name);
            Console.WriteLine("Y las canciones que tiene son: \n");
            for (int i = 0; i < this.playlist.Count; i++)
            {
                Console.WriteLine(this.playlist[i].Informacion() + "\n");
            }
        }
    }
}