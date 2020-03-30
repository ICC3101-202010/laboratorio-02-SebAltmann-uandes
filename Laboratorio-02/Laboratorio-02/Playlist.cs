using System;
using System.Collections.Generic;
namespace Laboratorio02
{
    public class Playlist
    {
        private string name;
        private List<Cancion> daList;

        public Playlist(string p_name, List<Cancion> canciones)
        {
            this.name = p_name;
            this.daList = canciones;
        }

        public String P_Informacion()
        {
            String list_str = "";
            foreach (Cancion song in daList)
            {
                list_str = list_str + song.Informacion() + "\n";
            }
            return "Nombre de la Playlist: "+name+ "\n"+list_str;
        }

        public String P_GetName()
        {
            return name;
        }
    }
}
