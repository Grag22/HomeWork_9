// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void SumTwoNumber(int NumM, int NumN)
{
    int sum = 0;
    for (int i = NumM; i <= NumN; i++)
    {
        sum = sum + NumM;
        NumM++;
    }
    Console.WriteLine(sum);
}

Console.Write("Введите число M: ");
int NumM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int NumN = Convert.ToInt32(Console.ReadLine());

SumTwoNumber(NumM, NumN);