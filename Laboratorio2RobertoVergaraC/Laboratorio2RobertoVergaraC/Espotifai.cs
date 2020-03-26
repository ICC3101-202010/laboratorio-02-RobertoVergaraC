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
                if (cancion == songs[i])
                    {
                        songs.Add(cancion);
                        return true; 
                    }
                else 
                    {
                        continue;
                    }
            }
            return false;
        }

        public void VerCanciones()
        {
            Console.WriteLine("La lista de canciones es:");
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i]);
            }
        }
    }
}
