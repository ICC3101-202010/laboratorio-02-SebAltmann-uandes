using System;
using System.Collections.Generic;
namespace Laboratorio02
{
    public class Espotifai
    {
        private List<Cancion> SongList = new List<Cancion>();

        public Espotifai()
        {
        }

        public bool AgregarCancion (Cancion cancion)
        {
            if (SongList.Count > 0)
            {
                foreach (Cancion Song in SongList)
                {
                    if (Song.GetName() == cancion.GetName() && Song.GetAlbum() == cancion.GetAlbum() && Song.GetArtist() == cancion.GetArtist())
                    {
                        Console.WriteLine("La canción ya existe.");
                        return false;
                    }
                }
            }

            SongList.Add(cancion);
            Console.WriteLine("Canción " + cancion.GetName() + " de " + cancion.GetArtist() + " agregada exitosamente.");

            return true;
        }

        public void VerCanciones()
        {
            if (SongList.Count > 0)
            {
                foreach (Cancion Song in SongList)
                {
                    Console.WriteLine(Song.Informacion());
                }
            } else
            {
                Console.WriteLine("No hay canciones en el gestor.");
            }
        }

        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> CPC = new List<Cancion>();

            if (criterio == "nombre")
            {
                foreach (Cancion Song in SongList)
                {
                    if (valor == Song.GetName())
                    {
                        CPC.Add(Song);
                    }
                }
            } else if (criterio == "artista")
            {
                foreach (Cancion Song in SongList)
                {
                    if (valor == Song.GetArtist())
                    {
                        CPC.Add(Song);
                    }
                }
            } else if (criterio == "album")
            {
                foreach (Cancion Song in SongList)
                {
                    if (valor == Song.GetAlbum())
                    {
                        CPC.Add(Song);
                    }
                }
            } else if (criterio == "genero")
            {
                foreach (Cancion Song in SongList)
                {
                    if (valor == Song.GetGenre())
                    {
                        CPC.Add(Song);
                    }
                }
            }

            if (CPC.Count == 0)
            {
                Console.WriteLine("No existen canciones que cumplan los requisitos.");
                Console.WriteLine(CPC);
            } else if (CPC.Count == 1)
            {
                Console.WriteLine("La siguiente canción cumple con los requisitos de la búsqueda:");
                Console.WriteLine(CPC);
            } else
            {
                Console.WriteLine("Las siguientes canciones cumplen con los requisitos de la búsqueda:");
                Console.WriteLine(CPC);
            }
            return CPC;
        }
    }
}
