using System;

namespace MySecondApp;
public static class Program
{
    public static void Main()
    {
        int masSize = 0;
        Console.WriteLine("Введите число элементов массива:");
        while (masSize <= 0)
        { 
            masSize = GetInt();
            if (masSize <= 0)
            {
                Console.WriteLine("Неверный тип данных");
            }
        }
        int[] mas = new int[masSize];

        for (int i = 0; i < mas.Length; i++)
        {
            Console.WriteLine("Введите элемент массива:");
            mas[i] = GetInt();
        }
        Console.WriteLine("Ваш массив:");
        for (int j = 0; j < mas.Length; j++)
        {
            Console.Write(mas[j] + " ");
        }

        int maxNumber = mas.Max();
        Console.WriteLine();
        Console.WriteLine("Наибольший элемент массива: " + maxNumber);

        int temporaryElement = 0;
        for (int g = 0; g < mas.Length; g++)
        {
            if ((mas[g] > temporaryElement) && (mas[g] < maxNumber))
            {
                temporaryElement = mas[g];
            }
        }
        Console.WriteLine("Второй наибольший элемент массива: " + temporaryElement);

    }

    public static int GetInt()  
    {
        int parseResult;
        while (true)
        {
            if (Int32.TryParse(Console.ReadLine(), out parseResult)) 
            {
                return parseResult;
            }
            else
            {
                Console.WriteLine("Неверный тип данных");
            }
        }
    }
}
