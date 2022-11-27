using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // media aritmetica a trei numere
            int a, b, c;
            float media;

            Console.WriteLine("Introduceti cele 3 numere: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            media = ((float)a + (float)b + (float)c) / 3;

            Console.WriteLine("Media artimetica este " + media);
        }
    }
}
