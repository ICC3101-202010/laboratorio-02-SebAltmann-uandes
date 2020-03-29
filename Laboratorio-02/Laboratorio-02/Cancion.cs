using System;
namespace Laboratorio02
{
    public class Cancion
    {
        private string nombre;
        private string album;
        private string artista;
        private string genero;

        public Cancion(string nombre, string album, string artista, string genero)
        {
            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;
        }

        public String Informacion()
        {
            return "genero: " + genero + ", artista: " + artista + ", album: " + album + ", nombre: " + nombre;
        }

        public String GetName()
        {
            return nombre;
        }

        public String GetAlbum()
        {
            return album;
        }

        public String GetArtist()
        {
            return artista;
        }

        public String GetGenre()
        {
            return genero;
        }
    }
}
