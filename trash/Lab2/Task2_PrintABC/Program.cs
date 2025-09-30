using System;
using System.Threading;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            PrintABC();
            Thread.Sleep(500); // задержка 0.5 с
        }
    }

    static void PrintABC()
    {
        Console.WriteLine("A");
        Console.WriteLine("B");
        Console.WriteLine("C");
    }
}
