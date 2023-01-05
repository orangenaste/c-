﻿// Нахождение факториала


namespace ConsoleApplication1
{
    class Program
    {
        // Рекурсивный метод
        static int factorial(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = factorial(i - 1) * i;
            return result;
        }

        static void Main(string[] args)
        {
        label1:
            Console.WriteLine("Введите число: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}! = {1}", i, factorial(i));
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректное число");
                goto label1;
            }

            Console.ReadLine();
        }
    }
}