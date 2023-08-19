// public class Program
// {
//     public static void Main()
//     {
//         long someLongNumber = 516144564564654;
//         int intNumber = Convert.ToInt32(someLongNumber);
//         Console.WriteLine(intNumber);
//     }
// }

// No caso do cast  Convert.ToInt32, o C# nos obriga a fazer um cast explícito, 
// pois ele sabe que pode haver perda de dados.


// Abaixo um exemplo quando ele consegue fazer o Cast Explícito
public class Program
{
    public static void Main()
    {
        long someLongNumber = 42;
        int intNumber = Convert.ToInt32(someLongNumber);

        Console.WriteLine(intNumber);
    }
}

