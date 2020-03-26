using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2RobertoVergaraC
{
    class Cancion
    {
        public string name;
        public string album;
        public string artist;
        public string genre;
        
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
