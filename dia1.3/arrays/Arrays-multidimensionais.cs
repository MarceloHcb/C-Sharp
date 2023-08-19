using System;
namespace Namespace2;
class Program
{
    static void Main2()
    {
        // Criar um array bidimensional (matriz) de inteiros com tamanho 3x3
        int[,] matriz = new int[3, 3];

        // Preencher a matriz com alguns valores
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[0, 2] = 3;
        matriz[1, 0] = 4;
        matriz[1, 1] = 5;
        matriz[1, 2] = 6;
        matriz[2, 0] = 7;
        matriz[2, 1] = 8;
        matriz[2, 2] = 9;

        // Imprimir os valores da matriz
        Console.WriteLine("Valores da matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Calcular a soma dos valores na diagonal principal
        int somaDiagonalPrincipal = 0;
        for (int i = 0; i < 3; i++)
        {
            somaDiagonalPrincipal += matriz[i, i];
        }

        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
    }
}
