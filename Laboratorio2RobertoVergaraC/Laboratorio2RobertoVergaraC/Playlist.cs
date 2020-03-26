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
        private string criterio;
        private string valor;


        private List<Cancion> playlist;

        public Playlist(string name, List<Cancion> playlist,string criterio, string valor)
        {
            this.name = name;
            this.criterio = criterio;
            this.valor = valor;
            this.playlist = playlist;
        }

        public string InformacionCanciones()
        {
            for (int i = 0; i < this.playlist.Count; i++)
            {
                Console.WriteLine("\n" + this.playlist[i].Informacion());
            }
            return "";
        }

        public string InformacionPlaylistNombre()
        {
            return "\nNombre Playlist: " + this.name + "\n";
        }

        public string InformacionPlaylistCriterioyValor()
        {
            return "Criterio: " + this.criterio + "\nValor: " + this.valor + "\n";
        }
    }
}
