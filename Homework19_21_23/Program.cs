int Palindrom(int num, int NumberOfFirstNumbers)
{
    while (num / Math.Pow(10, NumberOfFirstNumbers) > 1)
    {
        num /= 10;
    }

    Console.WriteLine(num);
    return num;

}
//int number = int.Parse(Console.ReadLine());
//if (number > 99)
//{
//  int x = number % 100;
//int y = Palindrom(number, 2);
//}
//else if (number > 9)
//{
//  int x = number % 10;
//int y = Palindrom(number, 1);
//}
//else
//{
//  Console.WriteLine("Введите число больше 9");
//}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во: ");
int NumberOfFirstNumbers = int.Parse(Console.ReadLine());
Palindrom(num, NumberOfFirstNumbers);