/*Напишите программу, которая перевернёт одномерный массив.
*/
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next (minValue, maxValue + 1);
    }
    return array;
}

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a max possible value of array: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[] newArray = CreateRandomArray (length, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);
*/
/* Напишите программу, которая принимает на вход три числа и
 проверяет, может ли существовать треугольник с сторонами такой длины.
*/

/*
bool TriangleTest(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    return false;
}

Console.WriteLine("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input C: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Checking the triangle for existence: " + TriangleTest(a, b, c));
*/


/* Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: a и b
/*


/*
int Fibonacci(int n, int a, int b)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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

Console.WriteLine("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input C: ");
int c = Convert.ToInt32(Console.ReadLine);
ShowArray(Fibonacci);
*/


/* Напишите программу, которая будет создавать копию заданного массива 
 с помощью поэлементного копирования.
*/


/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next (minValue, maxValue + 1);
    }
    return array;
}

int[] CloneArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++) newArray[i] = array[i];
    return newArray;
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

int[] original = CreateRandomArray (length, min, max);

int[] second = CloneArray(original);
second[0] += 1; 
ShowArray(original);
ShowArray(second);
*/