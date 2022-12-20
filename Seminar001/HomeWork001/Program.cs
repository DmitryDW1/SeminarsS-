// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

/*
Console.Write ("Input a first number: ");
double num_a = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input a second number: ");
double num_b = Convert.ToDouble(Console.ReadLine());
if (num_a > num_b)
    {
    Console.Write(num_a + " > " + num_b);
    }
else if (num_a < num_b)
    {
    Console.Write(num_b + " > " + num_a);
    }
else Console.Write(num_a + " = " + num_b);
*/

//Задача 4: Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

/*
Console.Write ("Input a first number: ");
double num_a = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input a second number: ");
double num_b = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input a third number: ");
double num_c = Convert.ToDouble(Console.ReadLine());
double max = num_a;
if (num_b > max)
    {
        max = num_b;
    }
if (num_c > max)
    {
        max = num_c;
    }
Console.Write ("The maximum of these numbers ");
Console.WriteLine (max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write ("Input a number: ");
double num_a = Convert.ToDouble(Console.ReadLine());
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

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
//все чётные числа от 1 до N.

/*
Console.Write ("Input a number: ");
double num_a = Convert.ToDouble(Console.ReadLine());
int current = 2;
if (num_a > 0)
    {
        while (current < num_a)
            {
                Console.Write (current + " ");
                current = current + 2;
            }
    }
else
    {
        current = current - 2;
        while (current > num_a)
            {
                Console.Write (current + " ");
                current = current - 2;
            }
    }
*/