using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Начало программы");
        // NeverCalled(); // не вызываем функцию
    }

    static void NeverCalled()
    {
        Console.WriteLine("Эта функция нигде не вызывается");
    }
}
