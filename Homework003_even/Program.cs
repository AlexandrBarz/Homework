Console.WriteLine("Программа проверки четности числа");
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число " + a + " является четным");
}
else
{
    Console.WriteLine("Число " + a + " является нечетным");
}