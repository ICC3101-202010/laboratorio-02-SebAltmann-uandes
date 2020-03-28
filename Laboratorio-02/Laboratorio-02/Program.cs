using System;

namespace Laboratorio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cancion TEST = new Cancion("A", "B", "C", "D");

            Console.WriteLine(TEST.Informacion());
        }
    }
}
