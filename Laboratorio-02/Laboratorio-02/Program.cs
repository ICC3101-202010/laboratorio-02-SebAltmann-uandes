using System;

namespace Laboratorio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cancion TEST = new Cancion("A", "B", "C", "Rock");
            Cancion TEST2 = new Cancion("a", "b", "c", "Rock");
            Espotifai SPOT = new Espotifai();
            String response = "x";
            while (true)
            {
                while (response != "A" && response != "a" && response != "V" && response != "v" && response != "S" && response != "s")
                {
                    Console.WriteLine("Bienvenido a Espotifai!\n");
                    Console.WriteLine("Agregar Canción: {A}");
                    Console.WriteLine("Ver Canciones: {V}");
                    Console.WriteLine("Salir: {S}");
                    response = Console.ReadLine();

                    if (response != "A" && response != "a" && response != "V" && response != "v" && response != "S" && response != "s")
                    {
                        Console.WriteLine("La respuesta no es válida.");
                    }

                    if (response == "A" || response == "a")
                    {
                        String new_name;
                        Console.Write("Nombre de la cancion: ");
                        new_name = Console.ReadLine();
                        String new_artist;
                        Console.Write("Artista de la cancion: ");
                        new_artist = Console.ReadLine();
                        String new_album;
                        Console.Write("Album de la cancion: ");
                        new_album = Console.ReadLine();
                        String new_genre;
                        Console.Write("Genero de la cancion: ");
                        new_genre = Console.ReadLine();
                        Cancion new_song = new Cancion(new_name, new_album, new_artist, new_genre);
                        SPOT.AgregarCancion(new_song);
                    }

                    if (response == "V" || response == "v")
                    {
                        SPOT.VerCanciones();
                    }

                    if (response == "S" || response == "s")
                    {
                        return;
                    }
                }
                response = "x";
            }
        }
    }
}
