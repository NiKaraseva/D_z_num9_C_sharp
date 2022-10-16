/* Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */ 

Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);

int SumRecur(int m, int n)
{
    if(m == n)
    {
        return m;
    }
    else
    {
        return(n + SumRecur(m, n - 1));
    }
}

Console.WriteLine(SumRecur(m, n));
