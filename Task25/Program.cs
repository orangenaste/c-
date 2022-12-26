// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// делать через метод цикла !! не через Pow

Console.WriteLine("Enter num: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter degree: ");
int B = Convert.ToInt32(Console.ReadLine());

ToDegree(A, B);
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{A} in {B} degree = {result}");
}