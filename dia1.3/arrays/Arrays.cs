using System;
namespace Namespace1;
class Program
{
    static void Main()
    {
        // Criar um array de inteiros com tamanho 5
        int[] numeros = new int[5];

        // Preencher o array com alguns valores
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;

        // Imprimir os valores do array
        Console.WriteLine("Valores do array:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        // Calcular a média dos valores no array
        int soma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }
        double media = (double)soma / numeros.Length;

        Console.WriteLine($"Média dos valores: {media}");

        // Procurar por um valor específico no array
        int valorProcurado = 30;
        bool encontrado = false;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == valorProcurado)
            {
                encontrado = true;
                break;
            }
        }

        Console.WriteLine($"Valor {valorProcurado} encontrado: {encontrado}");
    }
}
