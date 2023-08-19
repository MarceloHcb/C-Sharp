using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string envFilePath = ".env";
        string textFilePath = "meuarquivo.txt";

        // Dicionário de variáveis e valores para o .env
        var envVariables = new Dictionary<string, string>
        {
            { "API_KEY", "your-api-key" },
            { "DB_CONNECTION_STRING", "your-db-connection-string" },
            { "SECRET_KEY", "your-secret-key" }
        };

        
        string textContent = "Olá mundo!!";
        
        CreateEnvFile(envFilePath, envVariables);
        
        CreateTextFile(textFilePath, textContent);

        Console.WriteLine(".env e arquivo de texto criados com sucesso.");
    }

    static void CreateEnvFile(string filePath, Dictionary<string, string> envVariables)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var kvp in envVariables)
                {
                    writer.WriteLine($"{kvp.Key}={kvp.Value}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Erro ao criar o arquivo .env: {ex.Message}");
        }
    }

    static void CreateTextFile(string filePath, string content)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(content);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Erro ao criar o arquivo de texto: {ex.Message}");
        }
    }
}
