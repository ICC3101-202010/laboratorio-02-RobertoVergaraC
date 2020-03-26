using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2RobertoVergaraC
{
    class Cancion
    {
        private string name;
        private string album;
        private string artist;
        private string genre;
        
        public Cancion(string Name, string Album, string Artist, string Genre)
        {
            this.name = Name;
            this.album = Album;
            this.artist = Artist;
            this.genre = Genre;
        }

        public string Informacion()
        {
            return ("Nombre: " + this.name + "\n" + "Álbum: " + this.album + "\n" + "Artista: " + this.artist + "\n" + "Género: " + this.genre);
        }
    }
}
