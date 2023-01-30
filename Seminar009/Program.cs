// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
    //Console.Write(num + " ");
}

ShowNums(5);
*/
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(1234));

// f(1234) -> 4 + f(123)
// f(123) -> 3 + f(12)
// f(12) -> 2 + f(1)
// f(1) -> 1 + f(0)
// f(0) -> 0
// f(1) -> 1 + 0 = 1
// f(12) -> 2 + 1 = 3
// f(123) -> 3 + 3 = 6
// f(1234) - > 4 + 6 = 10
*/

/* Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
*/
/*
void ShowSerialNums(int num1, int num2)
{
    
    if(num1 > num2) 
    {
        Console.WriteLine(num1 + " " );
        ShowSerialNums(num1 - 1, num2);
    }
    else if(num2 > num1) 
    {
        Console.WriteLine(num2 + " " );
        ShowSerialNums(num1, num2 - 1);
    }
    else Console.WriteLine(num1);
}

ShowSerialNums(10, 1);
*/
/* Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B.
*/
double FinDegree(double a, double b)
{
    if(b > 0) return a*FinDegree(a, b - 1);
    if(b < 0) return 1/a*FinDegree(a, b + 1);
    else return 1;
}
Console.WriteLine("Введите число A");
double numA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B");
double numB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(FinDegree(numA, numB));


