/* Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
*/

/*
int getDegree (int numA, int numB)
{
    int result = 1;
    for (int i = 0; i != numB; i++)
    {
        result *= numA;
    }
    return result;
}

Console.WriteLine ("Возведение числа А в натуральную степень В");
Console.WriteLine ("Введите число А: ");
int numA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите число В: ");
int numB = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine (getDegree (numA, numB));
*/

/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
*/

/*
int getSum (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum  + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine ("Вычисление суммы цифр числе.");
Console.WriteLine (" Введите число :");
int num = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine (getSum (num));
*/

/* Задача 29: Напишите программу, которая задаёт массив 
из m элементов и выводит их на экран.
*/

/*
int[] CreateArray (int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine ("Введите значение " + i + " элемента массива");
        int value = Convert.ToInt32 (Console.ReadLine());
        array[i] = value;
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите размер массива: ");
int size = Convert.ToInt32 (Console.ReadLine());
int[] newArray = CreateArray (size);
ShowArray(newArray);
*/