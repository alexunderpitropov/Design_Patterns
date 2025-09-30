using System;

class Program
{
    static void Main()
    {
        CallLater();
    }

    static void CallLater()
    {
        SayHi();
    }

    static void SayHi()
    {
        Console.WriteLine("Hi! Эта функция определена ниже, но вызвана выше");
    }
}
