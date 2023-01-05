// Задача 68: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Функция Аккермана — всюду определённая вычислимая 
// функция, которая не является примитивно рекурсивной. 
// Функция Аккермана (m, n) определяется следующим образом: 
// Ackermann(0, n) = n+1; Ackermann(m,0) = Ackermann(m-1,1); 
// Ackermann(m, n) = Ackermann(m-1, Ackermann(m, n-1)), m>0, n>0

Console.Write("Enter positive number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter positive number N: ");
int n = Convert.ToInt32(Console.ReadLine());
AckermanFunction(m,n);

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}

void AckermanFunction(int m, int n)
{
    Console.WriteLine($"A({m}, {n}) = {Ackerman(m, n)}");
}

