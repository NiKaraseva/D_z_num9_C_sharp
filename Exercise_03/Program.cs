/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */ 

Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int AckermannRecurs(int m, int n)
{
    if(m == 0)
    {
        return (n + 1);
    }
    else 
    if((m != 0) && (n == 0))
        {
            return(AckermannRecurs(m - 1, 1)); 
        }
    else 
        {
            return(AckermannRecurs(m - 1, AckermannRecurs(m, n - 1)));
        }
}

Console.Write($"Значение A{(m, n)} = ");
Console.WriteLine(AckermannRecurs(m, n));
