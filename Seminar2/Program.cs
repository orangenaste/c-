// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

var random = new Random();

int randomNum = random.Next(10, 100);

Console.Write(randomNum);

int num1 = randomNum / 10;
int num2 = randomNum % 10;

if (num1>num2)
{
    Console.WriteLine(num1);
}
else if (num1<num2)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("They are equal");
}