// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Enter num: ");
int num = int.Parse(Console.ReadLine());
int[] array = {6, 7, 19, 345, 3};

bool wr = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        wr = true;
    }
}

string str = wr ? "Yes" : "No";
Console.WriteLine(str);