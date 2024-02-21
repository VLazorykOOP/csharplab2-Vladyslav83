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
        // Заданий масив
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Змінна для зберігання суми квадратів парних елементів
        int sumOfSquares = 0;

        // Проходимо по всіх елементах масиву
        foreach (int num in array)
        {
            // Перевіряємо, чи є елемент парним
            if (num % 2 == 0)
            {
                // Додаємо квадрат парного числа до суми
                sumOfSquares += num * num;
            }
        }

        // Виводимо суму квадратів парних елементів
        Console.WriteLine("Сума квадратів парних елементів: " + sumOfSquares);
    }

    static void Task2()
    {
        // Послідовність з n дійсних чисел
        double[] sequence = { 3, 1, 5, 2, 7, 1, 4, 6, 1, 9 };

        // Змінні для зберігання індексів першого та останнього мінімального елементів
        int minFirstIndex = -1;
        int minLastIndex = -1;

        // Змінні для зберігання індексів першого та останнього максимального елементів
        int maxFirstIndex = -1;
        int maxLastIndex = -1;

        // Знаходимо перший мінімальний елемент та його індекс
        double min = double.MaxValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < min)
            {
                min = sequence[i];
                minFirstIndex = i;
            }
        }

        // Знаходимо останній мінімальний елемент та його індекс
        for (int i = sequence.Length - 1; i >= 0; i--)
        {
            if (sequence[i] == min)
            {
                minLastIndex = i;
                break;
            }
        }

        // Знаходимо перший максимальний елемент та його індекс
        double max = double.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > max)
            {
                max = sequence[i];
                maxFirstIndex = i;
            }
        }

        // Знаходимо останній максимальний елемент та його індекс
        for (int i = sequence.Length - 1; i >= 0; i--)
        {
            if (sequence[i] == max)
            {
                maxLastIndex = i;
                break;
            }
        }

        // Перевіряємо, чи максимальний елемент зустрічається пізніше мінімального
        if (maxFirstIndex > minLastIndex)
        {
            Console.WriteLine("Максимальний елемент зустрічається пізніше мінімального.");
        }
        else
        {
            // Обчислюємо суму елементів між першим і останнім максимальними мінімальними елементами
            double sum = 0;
            for (int i = minFirstIndex + 1; i < maxLastIndex; i++)
            {
                sum += sequence[i];
            }

            Console.WriteLine($"Сума елементів між першим і останнім максимальними мінімальними елементами: {sum}");
        }
    }

    static void Task3()
    {
        // Введення розміру масиву
        Console.Write("Введіть n: ");
        int n = int.Parse(Console.ReadLine());

        // Створення масиву
        int[,] array = new int[n, n];

        // Заповнення масиву випадковими цілими числами від 0 до 99
        Random random = new Random();
        
                for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(0, 100);
            }
        }

        // Виведення масиву на екран
        Console.WriteLine("Масив розміром {0}×{0}:", n);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Task4()
    {
        // Example array dimensions
        int n = 4; // Number of rows
        int m = 3; // Number of elements in each row

        // Example stepped array
        int[,] steppedArray = new int[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        // Example range for product calculation
        int k1 = 1;
        int k2 = 2;

        // Array to store products
        int[] productArray = new int[m];

        // Calculate products for each column
        for (int col = 0; col < m; col++) {
            int product = 1;
            for (int row = k1 - 1; row < k2; row++) {
                product *= steppedArray[row, col];
            }
            productArray[col] = product;
        }

        // Print product array
        Console.WriteLine("Product Array:");
        for (int i = 0; i < m; i++) {
            Console.Write(productArray[i] + " ");
        }
    }
}