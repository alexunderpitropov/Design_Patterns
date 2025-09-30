void PrintABC()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

for (int i = 0; i < 3; i++)
{
    PrintABC();
    Thread.Sleep(500); // задержка 0.5 секунды
}
