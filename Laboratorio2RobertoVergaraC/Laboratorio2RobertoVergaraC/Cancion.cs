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

        public string Name { get => name; private set => name = value; }
        public string Album { get => album; private set => album = value; }
        public string Artist { get => artist; private set => artist = value; }
        public string Genre { get => genre; private set => genre = value; }

        public Cancion(string Name, string Album, string Artist, string Genre)
        {
            this.Name = Name;
            this.Album = Album;
            this.Artist = Artist;
            this.Genre = Genre;
        }

        public string Informacion()
        {
            return ("Nombre: " + this.Name + "\n" + "Álbum: " + this.Album + "\n" + "Artista: " + this.Artist + "\n" + "Género: " + this.Genre);
        }
    }
}
