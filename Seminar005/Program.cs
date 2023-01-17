/* Написать программу, которая определяет сумму 
отрицательных элементов в массиве.
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


int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input a {i + 1} element: ");
        array[i] = Convert.ToInt32 (Console.ReadLine());
    }

    return array;
}

/*
int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) 
        {
            sum += array[i]; // Можно избавиться от фигурных скобок
        }
    }
    return sum;
}
*/
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
/*
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a max possible value of array: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[] newArray = CreateRandomArray (length, min, max);
ShowArray(newArray);

int result = GetSumOfNegatives(newArray);
Console.WriteLine("Sum of negatives in this array is " + result);
*/

/* Написать программу, заменяющую положительные 
элементы массива на отрицательные и наоборот.
*/

int[] MirrorArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

/* Написать программу, определяющую, присутствует 
ли заданное число в массиве.
*/

bool IsNumberInArray(int[] array, int numb)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == numb) return true;
    return false;
}

/* Задать массив из n элементов, определить 
кол-во элементов, принадлежащих отрезку [a,b] включительно.
*/

int NumbersInArray(int[] array, int a, int b)
{
    if(a > b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= a && array[i] <= b) counter++;   
    }
    return counter;
}

int[] testArray;
testArray = CreateRandomArray(21, -11, 11);
ShowArray(testArray);
ShowArray(MirrorArray(testArray));

Console.WriteLine(IsNumberInArray(testArray, 0));
Console.WriteLine(NumbersInArray(testArray, -5, 5));