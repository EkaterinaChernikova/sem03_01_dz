//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Random random = new Random();
int[] numbers = new int[10];
int evensCount = 0;

for (int i = 0; i < numbers.Length; i++)
{
   numbers[i] = random.Next(100, 1000);

   if (numbers[i] % 2 == 0) 
   {
        evensCount++;
   } 
}

Console.WriteLine($"[{string.Join(" ", numbers)}] -> {evensCount}");

Console.ReadKey();
Console.Clear();

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] numbers2 = new int[6];
int sum = 0;

for (int i = 0; i < numbers2.Length; i++) 
{
    numbers2[i] = random.Next(-10 , 10);

    if (i % 2 != 0)
    {
        sum += numbers2[i];
    }
}

Console.WriteLine($"[{string.Join(" ", numbers2)}] -> {sum}");
Console.ReadKey();
Console.Clear();

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] numbers3 = new int[6];
int max = 0;
int min = 0;

for (int i = 0; i < numbers3.Length; i++) 
{
    numbers3[i] = random.Next(10, 100);

    if (i == 0)
    {
        min = numbers3[0];
        max = numbers3[0];
    }

    if (numbers3[i] > max) 
    {
        max = numbers3[i];
    }
    else if (numbers3[i] < min)
    {
        min = numbers3[i];
    }
}

int dif = max - min;

Console.WriteLine($"[{string.Join(" ", numbers3)}] -> {dif}");
Console.ReadKey();
