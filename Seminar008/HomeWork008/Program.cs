/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/

/*
int[,] Create2dRandomArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
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

void SortInDescendingOrder(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition]) maxPosition = k;
            }
            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }
        
    }
    Console.WriteLine();
}
int[,] newArray = Create2dRandomArray();
Show2dArray(newArray);
SortInDescendingOrder(newArray);
Show2dArray(newArray);
*/



/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.
*/

/*
int[,] Create2dRandomArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 8);
    int columns = rnd.Next(1, 8);
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(100);
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

void SmallestAmount(int[,] array)
{
    int minPosition = 1;
    int[] minSumRowElements = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        minSumRowElements[i] = sum;
        sum = 0;
        if(minSumRowElements[i] < minSumRowElements[minPosition]) minPosition = i;
    }
    Console.WriteLine($"The row number of the array with the smallest amount :{minPosition + 1}" );
}
    
int[,] newArray = Create2dRandomArray();
Show2dArray(newArray);
SmallestAmount(newArray);
*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

/*
int[,] Create2dArray()
{
    Console.WriteLine("Enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();
    
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(100);
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

void CreateProductMatrices(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

Console.WriteLine($"Create first matrix ");
int[,] firstMatrix = Create2dArray();

Console.WriteLine($"Create second matrix ");
int[,] secondMatrix = Create2dArray();

Show2dArray(firstMatrix);
Show2dArray(secondMatrix);
if(firstMatrix.GetLength(0) == secondMatrix.GetLength(1))
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    CreateProductMatrices(firstMatrix, secondMatrix, resultMatrix);
    Console.WriteLine("The product of matrices:");
    Show2dArray(resultMatrix);
}
else Console.WriteLine("The product of matrices does not make sense");
*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

/*
void Create3DArray(int[, ,] array3D, int minValue, int maxValue)
{
//Временный одномерный массив для случайных уникальных чисел
    int[] tempArray = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int tempNumber;
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        tempArray[i] = new Random().Next(minValue, maxValue);
        tempNumber = tempArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(minValue, maxValue);
                    j = 0;
                    tempNumber = tempArray[i];
                }
            }
        }
    }
//Заполнение трёхмерного массива уникальными числами, взятыми из одномерного массива
    int count = 0; 
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j ,k] = tempArray[count];
                count++;
            }
        }
    }
}

void Show3dArray(int[, ,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"layer: {i + 1}");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("\t" + array[i, j, k] + (i, j, k) + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine($"Enter a minimum value in the range from 10 to 100 inclusive :");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Enter a maximum value in the range from 10 to 100 inclusive :");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of layers: ");
int layers = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

if(layers * rows * columns < maxValue - minValue)
{
   int[, ,] array3D = new int[layers, rows, columns];
    Create3DArray(array3D, minValue, maxValue);
    Show3dArray(array3D); 
}
else Console.WriteLine("It is impossible to fill in the matrix: there are not enough unique numbers");
*/


/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
*/

int[,] Create2dSpiralArray(int rows, int columns, int initialvalue)
    {
    int[,] array = new int[rows, columns];
    int i = 0, j = 0;
    int moveUp = 0, moveDown = 0, moveLeft = 0, moveRight = 0;
    while(initialvalue <= rows * columns)
        {
        array[i, j] = initialvalue;
        if(i == moveUp && j < columns - 1 - moveRight) j++;
        else if(j == columns - 1 - moveRight && i < rows - 1 - moveDown) i++;
        else if(i == rows - 1 - moveDown && j > moveLeft) j--;
        else i--;

        if ((i == moveUp + 1) && (j == moveLeft) && (moveLeft != columns - 1 - moveRight))
        {
            moveUp++;
            moveDown++;
            moveLeft++;
            moveRight++;
        }
        initialvalue++;
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

Console.WriteLine("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the initial value: ");
int initialvalue = Convert.ToInt32(Console.ReadLine());

int[,] spiralArray = Create2dSpiralArray(rows, columns, initialvalue);
Show2dArray(spiralArray);


// Попробовал методом рекурсии из лекций. Заполняет три стороны по периметру, а потом змейкой. 
/*
int[,] Create2DArrayFillZero()
    {
        System.Console.WriteLine("Enter the rows of the array: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the columns of the array: ");
        int columns = Convert.ToInt32(Console.ReadLine());
       
        
        int[,] array = new int[rows, columns];
        
        return array;        
    }

void Create2dSpiralArray(int i, int j, int initialValue, int[,] array)
{ 
    
    if (i < array.GetLength(0) && i >= 0 && j >= 0 && j < array.GetLength(1))
    {
        if(array[i, j] == 0)
        {
            
            array[i, j] = initialValue;
            initialValue++;
            
            Create2dSpiralArray(i, j + 1, initialValue, array);
            Create2dSpiralArray(i + 1, j, initialValue, array);
            Create2dSpiralArray(i, j - 1, initialValue, array);
            Create2dSpiralArray(i - 1, j, initialValue, array);
            
            
        }
            
    }
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


int[,] array = Create2DArrayFillZero();
Create2dSpiralArray(0, 0, 1, array);
Show2dArray(array);
*/
