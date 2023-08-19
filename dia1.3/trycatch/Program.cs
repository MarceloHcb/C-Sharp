using System;

class Program
{
    static void Main(string[] args)
    {
        string[] chemicalProduct = new string[3];

        try
        {
            chemicalProduct[0] = "Cálcio";
            chemicalProduct[1] = "Zinco";
            chemicalProduct[2] = "Hidrazina";
            chemicalProduct[3] = "Anilina";

            Console.WriteLine("Itens químicos adicionados com sucesso.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Erro Específico, sabemos exatamente o motivo do erro.{ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Temos a mensagem, porém é um pouco incerto o que ocorreu.");
        }
    }
}

