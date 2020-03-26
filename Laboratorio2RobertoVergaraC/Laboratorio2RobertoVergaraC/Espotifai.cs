using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2RobertoVergaraC
{
    class Espotifai
    {
        List<Cancion> songs = new List<Cancion>();

        public Espotifai()
        {
           
        }
        
        public bool AgregarCancion(Cancion cancion)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                if (cancion.Informacion() == songs[i].Informacion())
                    {
                        return false;
                    }
                else
                {
                    continue;
                }
            }
            
            songs.Add(cancion);
            return true;
        }

        public void VerCanciones()
        {
            Console.WriteLine("\nLa lista de canciones es:");
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].Informacion());
                Console.WriteLine();
            }
        }
    }
}
