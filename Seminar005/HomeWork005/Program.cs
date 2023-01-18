/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.
*/

/*
int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (minValue, maxValue + 1);
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

void EvenNums(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 == 0) counter++;   
    }
    Console.Write(counter);
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray (length, 99, 1000);
ShowArray(newArray);
EvenNums(newArray);
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/

/*
int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (minValue, maxValue + 1);
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

int SumOddNums(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];   
    }
    return sum;
}


Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray (length, 99, 1000);
ShowArray(newArray);
SumOddNums(newArray);
Console.Write(SumOddNums(newArray));

*/
/* Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
*/


/*
double[] CreateRandomArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("| " + array[i] + " |");
    }
    Console.WriteLine();
}

double DiffNums(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        else if(array[i] > max) max = array[i];
    }
    diff = max - min;
    return diff;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] newArray = CreateRandomArray (length, 99, 1000);
ShowArray(newArray);
DiffNums(newArray);
Console.Write("The difference between the maximum and minimum array element: " + DiffNums(newArray));

*/