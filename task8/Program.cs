/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] matrix = CreateMatrix(3, 4);
Console.WriteLine("Задана матрица: ");
PrintMatrix(matrix);
matrix = SortMatrix(matrix);
Console.WriteLine("Матрица после сортировки: ");
PrintMatrix(matrix);

Console.ReadKey();
Console.Clear();

int[,] CreateMatrix(int height, int width)
{
    Random random = new Random();
    int[,] newMatrix = new int[height, width];

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = random.Next(-10, 10);
        }
    }

    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j].ToString().PadLeft(4));
        }

        Console.WriteLine();
    }
}

int[,] SortMatrix(int[,] matrix)
{
    int buffer = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = j; l < matrix.GetLength(1); l++)
            {
                if (matrix[i, j] < matrix[i, l])
                {
                    buffer = matrix[i, j];
                    matrix[i, j] = matrix[i, l];
                    matrix[i, l] = buffer;
                }
            }
        }
    }

    return matrix;
}


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] matrix2 = CreateMatrix(4, 3);
Console.WriteLine("Задана матрица: ");
PrintMatrix(matrix2);
Console.Write(" Номер строки с наименьшей суммой чисел: ");
Console.WriteLine(FindMinimalLineSum(matrix2));

Console.ReadKey();
Console.Clear();

int FindMinimalLineSum(int[,] matrix)
{
    int minimalSum = 0;
    int buffer = 0;
    int lineNumber = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            buffer += matrix[i, j];
        }

        if (i == 0)
        {
            minimalSum = buffer;
        }

        if (buffer < minimalSum)
        {
            minimalSum = buffer;
            lineNumber = i + 1;
        }

        buffer = 0;
    }

    return lineNumber;
}



/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix_01 = CreateMatrix(3, 4);
int[,] matrix_02 = CreateMatrix(4, 3);
Console.WriteLine(" Заданы две матрицы: ");
PrintMatrix(matrix_01);
Console.WriteLine();
PrintMatrix(matrix_02);
int[,] matrix_01_02 = MatrixMultiplication(matrix_01, matrix_02);
Console.WriteLine(" Результирующая матрица: ");
PrintMatrix(matrix_01_02);

Console.ReadKey();
Console.Clear();

int[,] MatrixMultiplication(int[,] matrix_01, int[,] matrix_02)
{
    int[,] newMatrix = new int[matrix_01.GetLength(0), matrix_02.GetLength(1)];

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix_02.GetLength(0); l++)
            {
                newMatrix[i, j] += matrix_01[i, l] * matrix_02[l, j];
            }
        }
    }



    return newMatrix;
}

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] array = new int[2, 2, 2] { { { 11, 22 }, { 33, 44 } }, { { 55, 66 }, { 77, 88 } } };
PrintThreeDimensionArray(array);

Console.ReadKey();
Console.Clear();

void PrintThreeDimensionArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write(array[i, j, l] + $"({i}, {j}, {l}) ");
            }

            Console.WriteLine();
        }
    }
}


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] matrix3 = new int[4, 4];
matrix3 = SpiralFillArray(matrix3);
Console.WriteLine(" Спирально заполненная матрица");
PrintMatrix(matrix3);

Console.ReadKey();

int[,] SpiralFillArray(int[,] matrix)
{
    int number = 0;
    int height = 0;
    int width = 0;
    int dx = 1;
    int dy = 0;
    int changeCount = 0;
    int gran = matrix.GetLength(1);
    int buffer;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[height, width] = number;
        number++;

        if (--gran == 0)
        {
            gran = matrix.GetLength(1) * (changeCount % 2) + matrix.GetLength(0) * ((changeCount + 1) % 2) - (changeCount / 2 - 1) -2;
            buffer = dx;
            dx = -dy;
            dy = buffer;
            changeCount++;
        }        

        width += dx;
        height += dy;
    }

    return matrix;
}