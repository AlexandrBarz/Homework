void Palindrom()
{
    int a, InverseNumber = 0, number;
    Console.WriteLine("Введите число для проверки:");
    int num = int.Parse(Console.ReadLine());
    for (number = num; num != 0; num /= 10)
    {
        a = num % 10;
        InverseNumber = InverseNumber * 10 + a;
    }
    if (number == InverseNumber)
    {
        Console.WriteLine("Число " + number + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число " + number + " не является палиндромом");
    }
}

void TableCube()
{
    Console.WriteLine("Введите число N:");
    int N = int.Parse(Console.ReadLine());
    if (N < 0) N *= -1;
    for (int number = 1; number <= N; number++)
    {
        double cub = Math.Pow(number, 3);
        Console.Write(cub + " ");
    }
}

void Distance()
{
    double dist = 0;
    Console.WriteLine("Введите координаты первой точки:");
    int xa = int.Parse(Console.ReadLine());
    int ya = int.Parse(Console.ReadLine());
    int za = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки:");
    int xb = int.Parse(Console.ReadLine());
    int yb = int.Parse(Console.ReadLine());
    int zb = int.Parse(Console.ReadLine());
    dist = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    Console.WriteLine("Расстояние между 2-мя точками = " + dist);
}

Console.WriteLine("Введите номер задания 1, 2 или 3:");

while (true)
{
    int exercise = int.Parse(Console.ReadLine());
    if (exercise == 1)
    {
        Console.WriteLine("Программа для проверки числа - является оно палиндромом или нет.");
        Palindrom();
    }
    if (exercise == 2)
    {
        TableCube();
    }
    if (exercise == 3)
    {
        Distance();
    }
    return;
}