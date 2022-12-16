//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int number)
{
int result = -1;
if (number >= 100)
    {
    while (number > 999)
    {
    number = number / 10;
    }
    result = number % 10;
    }
    return result; 
}

if (ThirdDigit(number) == -1)
{ 
    Console.WriteLine("Third digit doesn't exist");
}
else
{
Console.WriteLine($"Third digit is {ThirdDigit(number)}");
}
