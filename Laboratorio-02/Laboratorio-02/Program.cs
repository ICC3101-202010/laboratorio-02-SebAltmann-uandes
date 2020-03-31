using System;

namespace Laboratorio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Espotifai SPOT = new Espotifai();
            String response = "x";
            while (true)
            {
                while (response != "A" && response != "a" && response != "V" && response != "v" && response != "S" && response != "s" && response != "C" && response != "c" && response != "P" && response != "p" && response != "L" && response != "l")
                {
                    Console.WriteLine("Bienvenido a Espotifai!\n");
                    Console.WriteLine("Agregar Canción: {A}");
                    Console.WriteLine("Ver Canciones: {V}");
                    Console.WriteLine("Ver Canciones por Criterio: {C}");
                    Console.WriteLine("Crear playlist: {P}");
                    Console.WriteLine("Ver mis Playlists: {L}");
                    Console.WriteLine("Salir: {S}");
                    response = Console.ReadLine();

                    if (response != "A" && response != "a" && response != "V" && response != "v" && response != "S" && response != "s" && response != "C" && response != "c" && response != "P" && response != "p" && response != "L" && response != "l")
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

                    if (response == "C" || response == "c")
                    {
                        String response2 = "x";
                        Console.Write("¿Qué criterio desea utilizar? (Nombre/Artista/Album/Género)  ");
                        response2 = Console.ReadLine();
                        if (response2 == "Nombre"||response2=="nombre"||response2=="Artista"||response2=="artista"||response2=="Album"||response2=="album"||response2=="Género"||response2=="Genero"||response2=="género"||response2=="genero")
                        {
                            if (response2=="Nombre")
                            {
                                response2 = "nombre";
                            } else if (response2 == "Artista")
                            {
                                response2 = "artista";
                            } else if (response2 == "Album")
                            {
                                response2 = "album";
                            } else if (response2 == "Género" || response2 == "Genero" || response2 == "género")
                            {
                                response2 = "genero";
                            }
                            String response3 = "x";
                            Console.Write("¿Cuál es el "+response2+" que desea buscar?  ");
                            response3 = Console.ReadLine();
                            SPOT.CancionesPorCriterio(response2, response3);
                            response2 = "x";
                            response3 = "x";
                        } else
                        {
                            Console.WriteLine("Ése criterio no es válido.");
                        }
                    }

                    if (response == "P" || response == "p")
                    {
                        String new_pl_name = "x";
                        Console.Write("¿Qué nombre desea darle a la playlist?  ");
                        new_pl_name = Console.ReadLine();
                        String response2 = "x";
                        Console.Write("¿Qué criterio desea utilizar? (Nombre/Artista/Album/Género)  ");
                        response2 = Console.ReadLine();
                        if (response2 == "Nombre" || response2 == "nombre" || response2 == "Artista" || response2 == "artista" || response2 == "Album" || response2 == "album" || response2 == "Género" || response2 == "Genero" || response2 == "género" || response2 == "genero")
                        {
                            if (response2 == "Nombre")
                            {
                                response2 = "nombre";
                            }
                            else if (response2 == "Artista")
                            {
                                response2 = "artista";
                            }
                            else if (response2 == "Album")
                            {
                                response2 = "album";
                            }
                            else if (response2 == "Género" || response2 == "Genero" || response2 == "género")
                            {
                                response2 = "genero";
                            }
                            String response3 = "x";
                            Console.Write("¿Cuál es el " + response2 + " que desea utilizar?  ");
                            response3 = Console.ReadLine();
                            SPOT.GenerarPlaylist(response2, response3, new_pl_name);
                            response2 = "x";
                            response3 = "x";
                        }
                        else
                        {
                            Console.WriteLine("Ése criterio no es válido.");
                        }
                    }

                    if (response == "L" || response == "l")
                    {
                        Console.WriteLine(SPOT.VerMisPlaylists());
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
