/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите высоту массива: ");
int n = ReadInt("Введите ширину массива: ");

int[,] array = FillArray(m, n);

PrintArray(array);

Console.ReadKey();
Console.Clear();

int[,] FillArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }

        Console.WriteLine();
    }
}


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] array2 = FillArray(5, 4);

Console.WriteLine("Задан массив: ");
PrintArray(array2);

int b = ReadInt("Введите позицию элемента по высоте: ");
int c = ReadInt("Введите позицию элемента по ширине: ");

FindElement(b, c, array2);

Console.ReadKey();
Console.Clear();

void FindElement(int b, int c, int[,] array)
{
    if (b < array.GetLength(0) && b >= 0 &&
        c < array.GetLength(1) && c >= 0)
    {
        Console.WriteLine($"Значение элемента по указанной позиции: {array[b, c]}");
    }
    else
    {
        Console.WriteLine("Не существует элемента с такой позицией.");
    }
}

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] array3 = FillArray(6, 5);

Console.WriteLine("Задан массив: ");
PrintArray(array3);

Console.WriteLine("Среднее арифметическое каждого столбца: ");
CalculateAverageColumn(array3);

Console.ReadKey();

void CalculateAverageColumn(int[,] array)
{
    float average = 0;
    int sum = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }

        
        average = (float)sum / array.GetLength(0);
        Console.Write(average.ToString("F") + "\t");
        sum = 0;
    }
}