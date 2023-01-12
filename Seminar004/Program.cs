// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum (int num)
{
    int sum = 0;

    for (int current = 0; current <= num; current++)
    {
        sum += current;
    }
    return sum;
}

Comsole.WriteLine("Input a number: ");
int a = Convert.ToInt32 (Console.ReadLine());

int result = GetSum (a);
Console.WriteLine(result);
*/

// Напишите программу, которая принимает на 
//вход число N и выдаёт произведение чисел от 1 до N.
 /*
int getNum (int num)
{
    int fact = 1;
    for (int currentnum = 1; currentnum <= num; currentnum++)
    {
        fact *= currentnum;
    }
    return fact;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32 (Console.ReadLine());

int result = getNum (a);
Console.WriteLine(result);
*/


// Напишите программу, которая принимает на 
//вход число и выдаёт количество цифр в числе.

/*
int getNum (int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32 (Console.ReadLine());

int result = getNum (a);
Console.WriteLine(result);
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
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
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value of array: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[] newArray = CreateRandomArray (length, min, max);
ShowArray(newArray);