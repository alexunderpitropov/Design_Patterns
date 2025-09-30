# Лабораторная работа 1

**Тема:** Установка .NET

**Цель работы:** Ознакомиться с процессом установки .NET SDK и создания консольного приложения двумя способами: вручную и через CLI.

---

## Ход работы

### 1. Установка .NET
- На компьютер был установлен .NET SDK версии **8.0.414**.  
- Проверка версии через команду:

```powershell
dotnet --version
```

Результат: 
```
8.0.414
```

---

### 2. Создание проекта вручную
В папке `C:\DP\Lab1` были созданы два файла:

**Lab1.csproj:**
```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
  </PropertyGroup>
</Project>
```

**Program.cs:**
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello from manual .NET project!");
    }
}
```

Запуск программы:
```powershell
dotnet run
```

Результат:
```
Hello from manual .NET project!
```

---

### 3. Создание проекта через CLI
В папке `C:\DP` выполнена команда:

```powershell
dotnet new console -o Lab1CLI
cd Lab1CLI
dotnet run
```

Результат:
```
Hello, World!
```

---

## Выводы
В ходе лабораторной работы был установлен .NET SDK и проверена его работоспособность.  
Созданы два консольных приложения: одно вручную с `.csproj` и `Program.cs`, другое с помощью CLI команды `dotnet new console`. Оба приложения были успешно запущены.

---

## Скриншоты
1. Установка .NET и проверка версии.
2. Структура проекта `Lab1` и запуск.
3. Структура проекта `Lab1CLI` и запуск.