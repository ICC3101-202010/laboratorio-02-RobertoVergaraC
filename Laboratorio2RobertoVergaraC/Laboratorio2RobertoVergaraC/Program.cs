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
                Console.WriteLine("\n(a) Ver todas las canciones \n" + "(b) Agregar una canción \n" + "(c) Ver canciones por criterio \n" + "(d) Crear Playlist \n" + "(e) Ver mis Playlist \n" + "(f) Salir del Programa \n");
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
                    Console.WriteLine("\n" + spotify.AgregarCancion(cancion));
                }
                else if (option == "c")
                {
                    Console.WriteLine("\nSeleccione el criterio que desea (nombre, álbum, artista, género):");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el valor que desea:");
                    string valor = Console.ReadLine();
                    List<Cancion> ListaCanciones = spotify.CancionesPorCriterio(criterio, valor);
                    if (ListaCanciones.Count > 0)
                    {
                        Console.WriteLine("\nSu lista de canciones con criterio " + criterio + " de valor " + valor + " es: ");
                        for (int i = 0; i < ListaCanciones.Count; i++)
                        {
                            Console.WriteLine("\n" + ListaCanciones[i].Informacion());
                        }
                    }
                }
                else if (option == "d")
                {
                    Console.WriteLine("\nSeleccione el nombre que desea para su playlist:");
                    string nombrePLaylist = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el criterio que desea para su playlist (nombre, álbum, artista, género):");
                    string Criterio = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el valor que desea para su playlist:");
                    string Valor = Console.ReadLine();
                    Console.WriteLine(spotify.GenerarPlaylist(Criterio, Valor, nombrePLaylist));
                }
                else if (option == "e")
                {
                    spotify.VerMisPlaylists();
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
