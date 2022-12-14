// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

var random = new Random();
int randomNum = random.Next(100, 1000);
Console.WriteLine(randomNum);

int num1 = randomNum / 100;
int num2 = randomNum % 100;
int num3 = num2 / 10;
Console.WriteLine(num3);
