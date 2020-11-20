using System;

namespace CesarCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 0;
            string plainText = "";

            Console.WriteLine("inserisci chiave");
            key = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("inserisci testo");
            plainText = Console.ReadLine();


        }
    }
}
