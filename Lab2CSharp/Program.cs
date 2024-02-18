using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть номер завдання від 1 до 4:");
        string input = Console.ReadLine();
        int taskNumber;

        if (int.TryParse(input, out taskNumber) && taskNumber >= 1 && taskNumber <= 4)
        {
            switch (taskNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Номер завдання повинен бути від 1 до 4.");
        }
    }

    static void Task1()
    {
        // Вставте свій код для завдання 1 тут
    }

    static void Task2()
    {
        // Вставте свій код для завдання 2 тут
    }

    static void Task3()
    {
        // Вставте свій код для завдання 3 тут
    }

    static void Task4()
    {
        // Вставте свій код для завдання 4 тут
    }
}