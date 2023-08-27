using System;

namespace MainNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aula ao vivo!");

            string message = MyFunction.GetHelloMessage();
            Console.WriteLine(message);
        }
    }
}
