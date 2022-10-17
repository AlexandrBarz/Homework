// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void SummaElements(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма элементов в промежутке от {m} до {n} = {sum}");
        return;
    }
    sum = sum + (m++);
    SummaElements(m, n, sum);
}
Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
SummaElements(m, n, sum);
Console.ReadKey();