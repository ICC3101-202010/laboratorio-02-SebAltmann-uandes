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
    }
}
