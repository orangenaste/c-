// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter num: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"The sum of digits in number {num} is {result(num)}");

int result(int num)
{
    int sum = 0;
    while(num>0)
    {
    sum+=num%10;
    num/=10
    ;}
    return sum;
}