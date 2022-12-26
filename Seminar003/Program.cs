//Math.Pow(a,b)=a*b;
//Math.Sqrt(a)=корень из a;
//Math.Round(a,b); - степень точности вычислений;


// Напишите программу, которая по заданному номеру 
//четверти, показывает диапазон возможных 
//координат точек в этой четверти (x и y).

/*
void GetDiapazone(int quadrant)
{
    if (quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.WriteLine("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);
*/

// 1. Напишите программу, которая принимает на вход координаты 
//точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
//четверти плоскости, в которой находится эта точка.

// 2. Напишите программу, которая принимает на вход число 
//(N) и выдаёт таблицу квадратов чисел от 1 до N.

// 3. Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними
// в 2D пространстве.


void QuadLine(int num)
{
    int counter = 1;
    while (counter <= num)
    {
        Console.WriteLine(Math.Pow(counter, 2));
        ++counter;
    }
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
QuadLine(num);

/*
double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}
Console.WriteLine("Input coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate y2: ");
double y2 = Convert.ToDouble(Console.ReadLine()); 

double result = Math.Round(Distance(x1, y1, x2, y2));
Distance(x1, y1, x2, y2);
Console.WriteLine(result);
*/