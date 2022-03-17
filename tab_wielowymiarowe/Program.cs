using System;

namespace tab_wielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[5, 7]; //deklaracja tablicy 2w x 3k
            array2D[0, 0] = 1;
            array2D[1, 2] = 9;
            Console.WriteLine(array2D[0, 0]);
            Console.WriteLine(array2D[1, 2]);
            Console.WriteLine("\nWymiary:");
            Console.WriteLine(array2D.Length);
            Console.WriteLine("\nPobierz wymiar 1:");
            Console.WriteLine(array2D.GetLength(0));
            Console.WriteLine("\nPobierz wymiar 2:");
            Console.WriteLine(array2D.GetLength(1));
            //wyswietlenie tablicy
            Console.WriteLine("Wyświetlenie tablicy");
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }

            ///tablice 3 wymiarowa
            Console.WriteLine("Tablica 3d");
            int[,,] array3D = new int[2, 2, 2];
            array3D[0, 1, 0] = 9;
            Console.WriteLine(array3D[0, 1, 0]);
            // tablica tekstowa
            Console.WriteLine("\n Text Array - tablica tekstowa");
            string[,] textArray = { { "Hello", "World" },{"Witaj" ,"Świecie"} };
            Console.WriteLine(textArray[0,0]+" "+textArray[0,1]);
            Console.WriteLine(textArray[1,0]+" "+textArray[1,1]);

            Console.WriteLine();
            //Foreach
            Console.WriteLine("Foreach");
            Console.WriteLine();
            foreach (string item in textArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
