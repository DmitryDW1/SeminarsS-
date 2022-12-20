int CutNumber(int number)
{
    int sot = number /100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}

/*
int CutNumber(int number)
{
    return 10 * (number / 100) + number%10;
}
*/
 /*
int randnumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randnumber);

Console.WriteLine($"New version of a number {randnumber} is {newNumber}");

/*
bool IsEven(int num)
{
    if (num % 2 == 0)
        return true;
    else
        return false;
}
*/

/*
int  a = 5;

if (a > 0 && a % 2 == 0)
{

}
*/
// 1.Напишите программу, которая выводит случайное 
//число из отрезка [10, 99] и показывает 
//наибольшую цифру числа.

// 2.Напишите программу, которая будет принимать на 
//вход два числа и выводить, является ли второе 
//число кратным первому.

//3.Напишите программу, которая принимает на вход 
//два числа и проверяет, является ли одно 
//число квадратом другого.


/*
int MaxNum(int num)
{
    int first = num /10;
    int second = num % 10;
    if(first > second)
    return first;
    else return second; 
}

/*
int num = new Random().Next(10,100);
Console.WriteLine(num);
Console.WriteLine(MaxNum(num));
*/
/*
bool KratNum(int num1, int num2)
{
    if(num2 %num1 ==0 )
    return true;
    else return false;
}
/*
Console.Write(" Please input num1: ");

int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Please input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(KratNum(num1,num2));
*/
/*
bool QuadrNum(int num1, int num2)
{
    if(num1*num1==num2 || num2*num2 ==num1)
    return true;
    else return false;
}

Console.Write(" Please input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Please input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(QuadrNum(num1,num2));
*/
//153 -> 1 3 -> 13