# Лабораторная работа 2

**Тема:** Понимание базового проекта

---

## Часть 1. Компиляция, исполняемый файл

1. Удалены временные файлы `bin` и `obj`.
2. Попытка запуска программы без пересборки:
   ```powershell
   dotnet run --no-build
   ```
   👉 Результат: ошибка, так как исполняемый файл отсутствует.
3. Пересборка проекта:
   ```powershell
   dotnet build
   ```
   👉 Результат: успешная сборка, созданы `bin` и `obj`.
4. Запуск программы:
   ```powershell
   dotnet run
   ```
   или напрямую `.exe` из `bin/Debug/net8.0`.

---

## Часть 2. Базовые инструкции

### Задание 1. Hello, Jerry
**Program.cs:**
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, Jerry");
    }
}
```
**Вывод:**
```
Hello, Jerry
```

---

### Задание 2. Функция PrintABC
**Program.cs:**
```csharp
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            PrintABC();
            Thread.Sleep(500);
        }
    }

    static void PrintABC()
    {
        Console.WriteLine("A");
        Console.WriteLine("B");
        Console.WriteLine("C");
    }
}
```
**Вывод:**
```
A
B
C
A
B
C
A
B
C
```

---

### Задание 3. Функции A, B, C
**Program.cs:**
```csharp
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
```
**Вывод:**
```
Функция A начала работу
Функция B выполняется
Функция C выполняется
Функция A завершилась
Функция A начала работу
Функция B выполняется
Функция C выполняется
Функция A завершилась
```

---

### Задание 4. Функция без вызова
**Program.cs:**
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Начало программы");
        // NeverCalled(); // функция не вызвана
    }

    static void NeverCalled()
    {
        Console.WriteLine("Эта функция нигде не вызывается");
    }
}
```
**Вывод:**
```
Начало программы
```

---

### Задание 5. Порядок определения функций
**Program.cs:**
```csharp
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
```
**Вывод:**
```
Hi! Эта функция определена ниже, но вызвана выше
```

---

## Выводы
В ходе лабораторной работы были изучены артефакты компиляции и работа с временными папками `bin` и `obj`. Рассмотрено, почему программа не запускается без сборки. Были реализованы базовые инструкции на C#, функции и порядок их вызова. Все задания успешно выполнены.