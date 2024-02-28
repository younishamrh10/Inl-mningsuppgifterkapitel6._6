using System;

namespace uppgift_6_6
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en text");
            string text = Console.ReadLine().ToLower();
            string[] ord = text.Split(' ');
            Förändring(ord);
            Console.ReadKey();
        }
        static void Förändring(string[] ord)
        {
            for (int i = 0; i < ord.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(ord[i].ToUpper() + " ");
                }
                else
                {
                    Console.Write(ord[i].ToLower() + " ");
                }
            }
        }
    }
}