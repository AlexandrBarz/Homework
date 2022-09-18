Console.WriteLine("Введите 2 числа для сравнения");
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Число " + a + " больше чем " + b);
}
else
{
    Console.WriteLine("Число " + b + " больше чем " + a);
}