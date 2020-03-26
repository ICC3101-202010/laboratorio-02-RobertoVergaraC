using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2RobertoVergaraC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido! En el siguiente menu marque la letra de la opción que quiera realizar:");

            Espotifai spotify = new Espotifai();
            int contador = 1;
            string option;
            while (contador != 0)
            {
                Console.WriteLine("(a) Ver todas las canciones \n" + "(b) Agregar una canción \n" + "(c) Ver canciones por criterio \n" + "(d) Crear Playlist \n" + "(e) Ver mis Playlist \n" + "(f) Salir del Programa \n");
                option = Console.ReadLine();
                if (option == "a")
                {
                    spotify.VerCanciones();
                }
                else if (option == "b")
                {
                    Console.WriteLine("\nSeleccione el nombre de la canción:");
                    string Name = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el álbum de la canción:");
                    string Album = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el artista de la canción:");
                    string Artist = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el género de la canción:");
                    string Genre = Console.ReadLine();
                    Cancion cancion = new Cancion(Name, Album, Artist, Genre);
                    Console.WriteLine("\n" + spotify.AgregarCancion(cancion) + "\n");
                }
                else if (option == "c")
                {
                    Console.WriteLine("\nSeleccione el criterio que desea (nombre, álbum, artista, género):");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el valor que desea:");
                    string valor = Console.ReadLine();
                    List<Cancion> ListaCanciones = spotify.CancionesPorCriterio(criterio, valor);
                    for (int i= 0; i < ListaCanciones.Count; i++)
                    {
                        Console.WriteLine("\n" + ListaCanciones[i].Informacion() + "\n");
                    }
                }
                else if (option == "d")
                {
                    Console.WriteLine("\nSeleccione el nombre que desea para su playlist:");
                    string nombrePlaylist = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el criterio que desea para su playlist:");
                    string criterioPlaylist = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el valor que desea para su playlist:");
                    string valorPlaylist = Console.ReadLine();
                    List<Cancion> ListaCanciones2 = spotify.CancionesPorCriterio(criterioPlaylist, valorPlaylist);
                    Playlist playlist = new Playlist(nombrePlaylist,ListaCanciones2,criterioPlaylist,valorPlaylist);
                    Console.WriteLine(playlist.InformacionPlaylistNombre());
                    Console.WriteLine(playlist.InformacionCanciones());
                }
                else if (option == "e")
                {
                    Console.WriteLine(spotify.VerMisPLaylists());
                }
                else if (option == "f")
                {
                    contador = 0;
                }
                else
                {
                    Console.WriteLine("\nEsta opcion no es válida, ponga una que lo sea");
                }
            }
            
        }
    }
}
