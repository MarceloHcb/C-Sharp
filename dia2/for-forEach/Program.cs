for (int count = 0; count < 3; count++)
{
    Console.WriteLine("numero: " + count);
}

string[] names = new string[] { "Hulk", "Thor", "Loki" };
foreach (var name in names)
{
    Console.WriteLine(name);
}

for (int count = 0; count < 10; count++)
    Console.WriteLine(count);

int[] numbers = new int[] { 1, 2, 3, 4 };
var sum = 0;
foreach (var number in numbers)
    sum += number;

// var isClosed = false;
// while (!isClosed)
//     isClosed = CloseConnection();