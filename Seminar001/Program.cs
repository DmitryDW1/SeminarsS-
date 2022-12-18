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

//32465 / 10 = 3246
//32465 / 100 =324
//32465 / 1000 =32
//32465 / 10000 =3

//32465 % 10 = 5
//32465 % 100 = 65
//32465 % 1000 = 465
//32465 % 10000 = 2465

//354861 //354861 % 10000 / 100 = 48; /100 % 100 = 48


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

/*
Console.Write ("Input a first number: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second number: ");
int num_b = Convert.ToInt32(Console.ReadLine());
if (num_a > num_b)
    {
    Console.Write(num_a + ">" + num_b);
    }
else
    {
    Console.Write(num_b + ">" + num_a);
    }
*/

//Задача 4: Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

/*
Console.Write ("Input a first number: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second number: ");
int num_b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a third number: ");
int num_c = Convert.ToInt32(Console.ReadLine());
int max = num_a;
if (num_b > max)
    {
        max = num_b;
    }
if (num_c > max)
    {
        max = num_c;
    }
Console.Write ("the maximum of these numbers ");
Console.WriteLine (max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write ("Input a number: ");
int num_a = Convert.ToInt32(Console.ReadLine());
if (num_a == 0)
    {
        Console.WriteLine ("This is the most even number!!!");
    }
else 
    if (num_a%2 == 0)
        {
            Console.Write("This is an even number");
        }
    else
        {
            Console.Write("This is odd number");
        }
*/

//Напишите программу, которая на вход принимает число (N), а на выходе показывает 
//все чётные числа от 1 до N.

/*
Console.Write ("Input a number: ");
int num_a = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current < num_a)
    {
        Console.Write (current + " ");
        current = current + 2;
    }
*/
