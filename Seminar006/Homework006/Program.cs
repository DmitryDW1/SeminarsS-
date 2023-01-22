/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/


int[] CreateArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        Console.WriteLine($"Input a {i + 1} number: ");
        array[i] = Convert.ToInt32 (Console.ReadLine());
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

void NumbersGreaterZero(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    Console.WriteLine($"Numbers greater than 0: " + counter);
}

Console.Write("How many numbers will you enter? ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray (length);
ShowArray(newArray);
NumbersGreaterZero(newArray);



/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/


/*
void IntersectionPoint (int k1, int k2, int b1, int b2)
{
    if (k1 == k2) Console.WriteLine($"There is no intersection point.");
    else
    {
        int x = (b2 - b1)/(k1 - k2);
        int y = k1*x + b1;
        Console.WriteLine($"Intersection point: {x}, {y}");
    }
}

Console.WriteLine($"Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(k1, k2, b1, b2);
*/