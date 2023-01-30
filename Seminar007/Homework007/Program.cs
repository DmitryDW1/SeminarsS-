/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/


/*
double[,] Create2dRandomArray()
{
    Random rnd = new Random();
    int m = rnd.Next(10);
    int n = rnd.Next(10);
    int minValue = rnd.Next(0);
    int maxValue = rnd.Next(1000);
    double[,] array = new double[m, n];
    
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(rnd.Next(1000) + rnd.NextDouble(), 3);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t" + array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = Create2dRandomArray();
Show2dArray(newArray);
*/


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
*/


/*
double[,] Create2dRandomArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
    int minValue = rnd.Next(0);
    int maxValue = rnd.Next(1000);
    double[,] array = new double[rows, columns];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(rnd.Next(1000) + rnd.NextDouble(), 3);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t" + array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CheckingValueArrayElement (double[,] newArray)
{
    Console.WriteLine("Enter the row number: ");
    int userRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the column number: ");
    int userColumn = Convert.ToInt32(Console.ReadLine());
    if(userRow <= newArray.GetLength(0) & userColumn <= newArray.GetLength(1))
    {
        Console.WriteLine($"Your number " + newArray[userRow - 1, userColumn - 1]);
    }
    else Console.WriteLine("There is no such element");
}

double[,] newArray = Create2dRandomArray();
Show2dArray(newArray);
CheckingValueArrayElement(newArray);
*/


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
*/



int[,] Create2dRandomArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
    int minValue = rnd.Next(0);
    int maxValue = rnd.Next(1000);
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(1000);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t" + array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void AverageSumColumn(int[,] array)
{
    int sum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write("\t" + sum + "\t");
        sum = 0;
    }
    Console.WriteLine();
}
int[,] newArray = Create2dRandomArray();
Show2dArray(newArray);
AverageSumColumn(newArray);
