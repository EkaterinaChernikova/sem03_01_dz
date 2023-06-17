/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Numbers(int N)
{
    if (N < 1) return;
    Console.Write(N + " ");
    Numbers(N - 1);
}

Numbers(ReadInt("Введите значение N: "));

Console.ReadKey();
Console.Clear();

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 
Подсказка:
A(0, m) = m +1
A(n + 1, 0) = A(n, 1)
A(n + 1, m + 1) = A(n, A(n + 1, m))*/

int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");

void NumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum += m;
    m++;
    NumberSum(m, n, sum);
}

NumberSum(m, n, 0);

Console.ReadKey();
Console.Clear();

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа j и l.
j = 2, l = 3 -> A(j,l) = 9
j = 3, l = 2 -> A(j,l) = 29  */

int j = ReadInt("Введите неотрицательное число J: ");
int l = ReadInt("Введите неотрицательное число L: ");

static int A(int j, int l)
{
        if (j == 0) return l + 1;
        if (l == 0) return A(j - 1, 1);
        return A(j - 1, A(j, l - 1));
}

Console.WriteLine($"A({j}, {l}) = {A(j, l)}");
Console.ReadKey();