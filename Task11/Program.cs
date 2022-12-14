// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98 

var random = new Random();

int randomNum = random.Next(100, 1000);

Console.Write(randomNum);

int num1 = randomNum / 100;
int num2 = randomNum / 10;
int num3 = randomNum - num1*100 - num2*10;

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
