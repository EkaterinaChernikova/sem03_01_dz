// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число А: ");
int.TryParse(Console.ReadLine(), out int A);
Console.Write("Введите число Б: ");
int.TryParse(Console.ReadLine(), out int B);

int C = A;

for (int i = 1; i < B; i++)
{
    C *= A;
}

Console.WriteLine($"Число {A} в степени {B} равно: {C}");
Console.ReadKey();
Console.Clear();

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
string userInput = Console.ReadLine();
int sum = 0;

for (int i = 0; i < userInput.Length; i++)
{
    sum += int.Parse(userInput[i].ToString());
}

Console.WriteLine($"Сумма цифр введённого числа: {sum}");
Console.ReadKey();
Console.Clear();


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Random random = new Random();
int arrayLenght = 8;
int[] numbers = new int[arrayLenght];

for (int i = 0; i < arrayLenght; i++)
{
    numbers[i] = random.Next(0, 10);
}

Console.WriteLine($"Заданный программой массив: [" + string.Join(", ", numbers) + "]");
Console.ReadKey();