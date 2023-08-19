public class SwitchCase
{
public static string IdentifyPolygon(int sideCount)
{
    var name = string.Empty;
        name = sideCount switch
        {
            < 3 => "Não é um polígono",
            3 => "Triângulo",
            4 => "Quadrado",
            5 => "Pentágono",
            _ => "Polígono não identificado",
        };
        return name;
}
  public static void Main()
    {   
        Console.WriteLine("Digite o número de lados do polígono");
        int sides = int.Parse(Console.ReadLine()?.Trim() ?? "0");       
        string polygonName = IdentifyPolygon(sides);
        Console.WriteLine($"Um polígono com {sides} lados é um {polygonName}");
    }
}