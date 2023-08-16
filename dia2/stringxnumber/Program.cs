public class Program
{
    public static void Main()
    {
        string someString = "42";
        int convertInt = Convert.ToInt32(someString);
        Console.WriteLine(convertInt);
        
        double someDouble = 150.60;
        Console.WriteLine(someDouble.ToString());
        string? installments = Console.ReadLine();
        int installmentsInt = Convert.ToInt32(installments);
        double installmentAmount = someDouble / installmentsInt;
        Console.WriteLine("O valor da parcela é: " + installmentAmount);
    }
}

// bool canConvert = Int32.TryParse(userEntry, out valueConverted)

