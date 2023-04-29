//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number/100;
int b = number%10;
int result = (number - (a * 100) - b) / 10;
System.Console.WriteLine($"Вторая цифра данного числа: {result}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
    System.Console.WriteLine($"{num} - третьей цифры тут нет.");
}
else if(num >= 100)
{
    while(num >= 1000)
    {
        num /= 10;
    }

    int k = num % 10;
    System.Console.WriteLine($"Третья цифра: {k}");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day >= 1 && day <= 5)
{
    System.Console.WriteLine("Сегодня не выходной.");
}
else if(day == 6 || day == 7)
{
    System.Console.WriteLine("Сегодня выходной. Ура!");
}
else
{
    System.Console.WriteLine("Такого дня нет и не будет. ни-ког-да!");
}