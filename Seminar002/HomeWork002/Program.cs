//Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

/*
int AverageFigure(int num) 
{
    return (num % 100) / 10;
}
Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 & num < 1000) Console.Write($"Second digit " + AverageFigure(num));
else if (num < -99 & num > -1000) 
{
    num = num * (-1);
    Console.Write($"Second digit " + AverageFigure(num));
}
else Console.Write("Sorry, there is no three-digit number");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.

/*
int ThirdDigit(int num)
{
    while (num >= 1000) num = num / 10;
    return num % 10;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99) Console.Write(ThirdDigit(num));
else if (num < -99) 
{
    num = num * (-1);
    Console.Write(ThirdDigit(num));
}
else Console.Write("Sorry, there is no third digit in your number");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Weekend(int num)
{
    if (num >= 1 & num <=7)
    {
        if (num >1 & num <=5) return false;
        else return true;
    }
    else return false;
}
Console.Write("Input the digit of the day of the week. It's a weekend?: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1 || num > 7) Console.Write("It's not a day of the week");
else Console.Write(Weekend(num));
*/