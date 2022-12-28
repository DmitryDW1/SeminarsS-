// Задача 19. Напишите программу, которая принимает на вход
// число и проверяет, является ли оно палиндромом.

/*
bool Polindrome(int num)
{
    int rezult = 0;
    if (num < 0)
    {
        num = (-1) * num;
    }
    int temp_num = num;
    while (num > 0)
    {
        rezult = rezult * 10 + num % 10;
        num = num / 10;
    }
    if (rezult == temp_num)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Let's check if your number is a palindrome. Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Polindrome(num));
*/

// Задача 21. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}
Console.WriteLine("Calculate the distance between two points in 3d space");
Console.WriteLine("Input coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate y2: ");
double y2 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Input coordinate z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(Distance(x1, y1, x2, y2, z1, z2));
Distance(x1, y1, x2, y2, z1, z2);
Console.WriteLine("Distance " + result);
*/

// Задача 23. Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void QuadLine(int num)
{
    int counter = 1;
    while (counter < num)
    {
        Console.WriteLine(Math.Pow(counter, 3));
        ++counter;
    }
}
Console.Write("Up to what number should the cube table be calculated? Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
QuadLine(num);
*/
