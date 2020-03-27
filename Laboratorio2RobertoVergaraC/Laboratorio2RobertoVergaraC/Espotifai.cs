using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2RobertoVergaraC
{
    class Espotifai
    {
        private List<Cancion> songs = new List<Cancion>();
        private List<Playlist> playlists = new  List<Playlist>();

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
            Console.WriteLine("\nLa lista de canciones es:\n");
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].Informacion());
                Console.WriteLine();
            }
        }

        public List<Cancion> CancionesPorCriterio(String criterio, String valor) //critero = género ; valor = pop
        {
            List<Cancion> playlist = new List<Cancion>();
            while (true)
            {
                if (criterio == "nombre" || criterio == "Nombre" || criterio == "NOMBRE")
                {
                    for (int i = 0; i < songs.Count; i++)
                    {
                        if (songs[i].Name == valor)
                        {
                            playlist.Add(songs[i]);
                        }
                    }
                    if (playlist.Count == 0)
                    {
                        Console.WriteLine("\nNo se han encontrado canciones con el valor solicitado, por lo que se le retornara su lista de canciones vacia\n");
                        return playlist;
                    }
                    else
                    {
                        Console.WriteLine("\nSu lista de canciones con criterio " + criterio + " de valor " + valor + " es:\n");
                        return playlist;
                    }
                }
                else if (criterio == "álbum" || criterio == "album" || criterio == "Álbum" || criterio == "Album" || criterio == "ÁLBUM" || criterio == "ALBUM")
                {
                    for (int i = 0; i < songs.Count; i++)
                    {
                        if (songs[i].Album == valor)
                        {
                            playlist.Add(songs[i]);
                        }
                    }
                    if (playlist.Count == 0)
                    {
                        Console.WriteLine("\nNo se han encontrado canciones con el valor solicitado, por lo que se le retornara su lista de canciones vacia\n");
                        return playlist;
                    }
                    else
                    {
                        Console.WriteLine("\nSu lista de canciones con criterio " + criterio + " de valor " + valor + " es:\n");
                        return playlist;
                    }
                }
                else if (criterio == "artista" || criterio == "Artista" || criterio == "ARTISTA")
                {
                    for (int i = 0; i < songs.Count; i++)
                    {
                        if (songs[i].Artist == valor)
                        {
                            playlist.Add(songs[i]);
                        }
                    }
                    if (playlist.Count == 0)
                    {
                        Console.WriteLine("\nNo se han encontrado canciones con el valor solicitado, por lo que se le retornara su lista de canciones vacia\n");
                        return playlist;
                    }
                    else
                    {
                        Console.WriteLine("\nSu lista de canciones con criterio " + criterio + " de valor " + valor + " es:\n");
                        return playlist;
                    }
                }
                else if (criterio == "género" || criterio == "genero" || criterio == "Género" || criterio == "Genero" || criterio == "GÉNERO" || criterio == "GENERO")
                {
                    for (int i = 0; i < songs.Count; i++)
                    {
                        if (songs[i].Genre == valor)
                        {
                            playlist.Add(songs[i]);
                        }
                    }
                    if (playlist.Count == 0)
                    {
                        Console.WriteLine("\nNo se han encontrado canciones con el valor solicitado, por lo que se le retornara su lista de canciones vacia\n");
                        return playlist;
                    }
                    else
                    {
                        Console.WriteLine("\nSu lista de canciones con criterio " + criterio + " de valor " + valor + " es:\n");
                        return playlist;
                    }
                }
                else
                {
                    Console.WriteLine("\n¡Error! El criterio seleccionado no existe, por lo tanto se le retornara su lista de canciones vacia\n");
                    return playlist;
                }
            }
        }

        public bool GenerarPlaylist(string criterio, string valorCriterio, string nombrePlaylist)
        {
            Espotifai espotifai = new Espotifai();
            Playlist nuevaPlaylist = new Playlist(nombrePlaylist, espotifai.CancionesPorCriterio(criterio, valorCriterio));
            for (int i = 0; i < playlists.Count; i++)
            {
                if (nuevaPlaylist.Name == playlists[i].Name)
                {
                    Console.WriteLine("\nEl nombre de la Playlist ya existe, por lo que no se puede agregar\n");
                    return false;
                }
                else if (criterio != "nombre" || criterio != "Nombre" || criterio != "NOMBRE" || criterio != "álbum" || criterio != "album" || criterio != "Álbum" || criterio != "Album" || criterio != "ÁLBUM" || criterio != "ALBUM" || criterio != "artista" || criterio != "Artista" || criterio != "ARTISTA" || criterio != "género" || criterio != "genero" || criterio != "Género" || criterio != "Genero" || criterio != "GÉNERO" || criterio != "GENERO")
                {
                    Console.WriteLine("\nEl criterio que selecciono no existe\n");
                    return false;
                }
                else
                {
                    continue;
                }
            }
            playlists.Add(nuevaPlaylist);
            nuevaPlaylist.InformacionPlaylist();
            return true;
        }

        public string VerMisPlaylists()
        {
            Console.WriteLine("\nLa lista de playlists es:\n");
            for (int i = 0; i < playlists.Count; i++)
            {
                playlists[i].InformacionPlaylist();
            }
            return "";
        }
    }
}
