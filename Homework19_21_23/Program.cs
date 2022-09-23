void Palindrom()
{
    int a, InverseNumber = 0, number;
    Console.WriteLine("Введите число для проверки: ");
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

Console.WriteLine("Введите номер задания 1, 2 или 3:");
while (true)
{
    int exercise = int.Parse(Console.ReadLine());
    if (exercise == 1)
    {
        Console.WriteLine("Программа для проверки числа - является оно палиндромом или нет.");
        Palindrom();
    }
//    if (exercise == 2)
//    {
//        Third_Digit();
//    }
//    if (exercise == 3)
//    {
//        Day_Off();
//    }
return;
}