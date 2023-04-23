//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a, b;
 
Console.WriteLine("Введите два числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} наибольшее число, число {b} наименьшее");
}
else
{
    Console.WriteLine($"{b} наибольшее число, наименьшее {a} число");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int c, d, e;
 
Console.WriteLine("Введите три числа : ");
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());
e = Convert.ToInt32(Console.ReadLine());

if (c > d && c > e)
{
    Console.WriteLine($"{c} наибольшее число");
}
else if(d > c && d > e)
{
    Console.WriteLine($"{d} наибольшее число ");
}
else if(e > c && e > d)
{
    Console.WriteLine($"{e} наибольшее число ");
}
Console.ReadKey();

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

int z;                             
Console.Write("введите число: ");
z = Convert.ToInt32(Console.ReadLine());
 
if (z % 2==1)
{
    Console.WriteLine("число нечетное");
           
}
else
{
    Console.WriteLine("Число четное");
}

Console.ReadKey();

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
    
Console.Write($"Четные числа в интервале от 1 до {n}");
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}