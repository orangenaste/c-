// Задача 66: Задайте значения M и N. Напишите 
// программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter first number: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter last number: ");
int m = int.Parse(Console.ReadLine());
PrintNumber(n, m);

int SumNaturalfromMtoN(int m, int n)
{
    if (m > n) return 0;
    else return m + SumNaturalfromMtoN(m + 1, n);
}

void PrintNumber(int n, int m)
{
    Console.WriteLine($"The sum of elements from {m} to {n} = {SumNaturalfromMtoN(n, m)}");
}