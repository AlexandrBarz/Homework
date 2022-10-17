// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int n)
{
    if (n < 0)
    {
        Console.WriteLine($"Число {n} не является натуральным числом");
        return;
    }
    if (n == 0) return;
    Console.Write("{0,3}", n);
    NaturalNumbers(n - 1);
}

int n = ReadData("Введите натуральное число N: ");
Console.WriteLine($"Наруральные числа от {n} до 1:");
NaturalNumbers(n);
Console.ReadKey();