//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] numbers;
int aboveZeroCount = 0;

Console.Write(" Введите произвольное количество целых чисел через пробел: ");

numbers = ConvertToInt(Console.ReadLine().Split(' '));
aboveZeroCount = CountNumbersAboveZero(numbers);

Console.WriteLine($"[{string.Join(" ", numbers)}] -> {aboveZeroCount}");

int[] ConvertToInt(string[] splitLine)
{
    int[] numbers = new int[splitLine.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        int.TryParse(splitLine[i], out numbers[i]);
    }

    return numbers;
}

int CountNumbersAboveZero(int[] numbers)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        count += numbers[i] > 0 ? 1 : 0;
    }

    return count;
}

Console.ReadKey();
Console.Clear();


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float[] numbers2 = new float[4];

Console.Write("Введите числа k1, k2, b1, b2, через пробел: ");
numbers2 = ConvertToFloat(Console.ReadLine().Split(' '));

float y, x;

if (numbers2.Length < 4)
{
    Console.WriteLine("Вы ввели не достаточное кол-во чисел.");
}
else if (numbers2[0] == numbers2[1])
{
    Console.WriteLine("Точка пересечения прямых по заданным числам не существует, они параллельны.");
}
else
{
    CalculateDots(out y, out x, numbers2);

    Console.WriteLine($"Точка пересечения прямых по заданным числам: ({x}, {y})");
}

Console.ReadKey();

float[] ConvertToFloat(string[] splitLine)
{
    float[] numbers = new float[splitLine.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        float.TryParse(splitLine[i], out numbers[i]);
    }
    
    return numbers;
}

void CalculateDots(out float y, out float x, float[] numbers)
{
    y = (numbers[2] * numbers[1] - numbers[3] * numbers[0]) / (numbers[1] - numbers[0]);
    x = (y - numbers[2]) / numbers[0];
}