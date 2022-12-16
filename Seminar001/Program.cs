//int a = 5, b = 4; //Целые числа
//int a = 22.6; //Вещественные числа
//double a =
//Console.WriteLine("My numbers are " + a + " and " + b + "and this good!");
//Console.WriteLine($"My numbers are " + a + " and " + b + "and this good!");
//Вывод числа

//Console.Write("Input a number: ");
//int number = Convert.ToInt32(Console.ReadLine());//Запомнить эти две строки!!!

//Семинар 1.

//Задача 1. Напишите программу, которая на вход принимает два 
//числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if (num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

//Задача 2. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while (current <= number)
{
    Console.Write(current + " ");
    current = current + 1; // current += 1; current -= 5; current /=5; current++
}
*/

//25 / 10 = 2
//25 % 10 = 5

32465 / 10 = 3246
32465 / 100 =324
32465 / 1000 =32
32465 / 10000 =3

32465 % 10 = 5
32465 % 100 = 65
32465 % 1000 = 465
32465 % 10000 = 2465

354861 //354861 % 10000 / 100 = 48; /100 % 100 = 48

