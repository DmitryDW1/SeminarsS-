/* Задайте двумерный массив. Напишите программу, которая поменяет
 местами первую и последнюю строку массива.
 */


/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");  // Это частный случай создания массива
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];


    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write(array[i, j] + "\t"); // / - это для примера
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1 >= 0 && r1 < array.GetLength(0) &&
       r2 >= 0 && r2 < array.GetLength(0) &&
       r1 != r2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.Write("Input a number of first row to change");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of second row to change");
int row2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, row1, row2);
Show2dArray(newArray);
*/

/* Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы.
*/

/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");  // Это частный случай создания массива
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];


    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write(array[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Transpond(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for(int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
if(newArray.GetLength(0) == newArray.GetLength(1))
{
    Transpond(newArray);
    Show2dArray(newArray);
}
*/

/* Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.
*/

int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");  // Это частный случай создания массива
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];


    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write(array[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] FindMin(int[,] array)
{
    int[] minPosition = new int[2];
    int minValue = array[0, 0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < minValue)
            {
                minValue = array[i, j];
                minPosition[0] = i;
                minPosition[1] = j;
            }
        }
    }
    return minPosition;
}

int[,] RemoveArray(int[,] array, int[] Position)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i - Convert.ToInt32(i >= Position[0] + 1), j - Convert.ToInt32(j >= Position[1] + 1)] = array[i, j];
        }
    }
    return newArray;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int[] minValue = FindMin(newArray);
Console.WriteLine($"{minValue[0]} {minValue[1]}");
int[,] newArray2 = RemoveArray(newArray, FindMin(newArray));
Show2dArray(newArray);
