using System;

namespace JaggedArrayExample
{
    class Program
    {
        static void Main3()
        {
            // Criando um jagged array com três arrays internos de tamanhos diferentes
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9 };

            // Acessando e imprimindo os elementos do jagged array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
