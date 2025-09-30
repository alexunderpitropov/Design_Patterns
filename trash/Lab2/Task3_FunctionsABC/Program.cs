using System;

class Program
{
    static void Main()
    {
        A();
        A();
    }

    static void A()
    {
        Console.WriteLine("Функция A начала работу");
        B();
        C();
        Console.WriteLine("Функция A завершилась");
    }

    static void B()
    {
        Console.WriteLine("Функция B выполняется");
    }

    static void C()
    {
        Console.WriteLine("Функция C выполняется");
    }
}
