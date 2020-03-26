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
            Console.WriteLine("Bienvenido! En el siguiente menu marque el número de la opción que quiera realizar:");

            Espotifai spotify = new Espotifai();
            int contador = 1;
            string option;
            while (contador != 0)
            {
                Console.WriteLine("(a) Ver todas las Canciones \n" + "(b) Agregar una Canción \n" + "(c) Salir del programa \n");
                option = Console.ReadLine();
                if (option == "a")
                {
                    spotify.VerCanciones();
                }
                else if (option == "b")
                {
                    Console.WriteLine("\nSeleccione el nombre de la canción:");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el álbum de la canción:");
                    string album = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el artista de la canción:");
                    string artist = Console.ReadLine();
                    Console.WriteLine("\nSeleccione el género de la canción:");
                    string genre = Console.ReadLine();
                    Cancion cancion = new Cancion(name, album, artist, genre);
                    Console.WriteLine("\n" + spotify.AgregarCancion(cancion) + "\n");
                }
                else if (option == "c")
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
