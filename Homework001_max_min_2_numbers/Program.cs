Console.WriteLine("Введите 2 числа для сравнения");
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Первое число " + a + " больше чем второе -  " + b);
}
else if (a == b)
{
    Console.WriteLine("Числа равны между собой");
}
else
{
    Console.WriteLine("Второе число " + b + " больше чем первое -  " + a);
}