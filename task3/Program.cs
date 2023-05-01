//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int lenght = number.Length;

if(lenght != 5)
{
    Console.WriteLine("Число не является пятизначным.");
}
else
{
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordA = new int[3]; 
int[] coordB = new int[3];

Console.Write("Введите координаты точки А, через пробел: ");
string userInput = Console.ReadLine();
string[] splitLine = userInput.Split(' ');

coordA[0] = Convert.ToInt32(splitLine[0]);


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for(int i = 1; i <= num; i++)
{
    Console.Write($" {Math.Pow(i, 3)}");
}