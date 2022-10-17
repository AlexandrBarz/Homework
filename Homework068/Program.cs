// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else
    {
        return (AkkermanFunc(m - 1, AkkermanFunc(m, n - 1)));
    }
}

Console.Write("Введите положительное число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите положительное число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Итог вычисления функции = {AkkermanFunc(m, n)}");
Console.ReadKey();