// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

/*
void ShowNumbers(int startNumber)
{
    Console.Write(startNumber + " ");
    if (startNumber > 1) ShowNumbers(startNumber - 1);
}

Console.WriteLine("Input number: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
ShowNumbers(startNumber);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int ShowSumNumbers(int numberM, int numberN)
{
    int sum = numberM;
    if (numberM != numberN) return numberM + ShowSumNumbers(numberM + 1, numberN);
    return sum;
}

Console.WriteLine("Input number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from M to N: {ShowSumNumbers(numberM, numberN)}");
*/



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int AccermanFunction(int numberM, int numberN)
{
    if(numberM == 0) return numberN + 1;
    if(numberN == 0) return AccermanFunction(numberM - 1, 1);
    else return AccermanFunction(numberM - 1, AccermanFunction(numberM, numberN -1));
}

Console.WriteLine("Input number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{AccermanFunction(numberM, numberN)}");
*/