// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter number : ");
string enterNum = Console.ReadLine();
int Length = enterNum.Length;

if (Length == 5)
{
    if (enterNum[0] == enterNum[4] && enterNum[1] == enterNum[3])
    {
        Console.WriteLine($"{enterNum} - this number is a palindrome");
    }
    else
    {
        Console.WriteLine($"{enterNum} - this number is not a palindrome");
    }
}
else
{
    Console.WriteLine($"{enterNum} - this is not a 5-digit number");
}