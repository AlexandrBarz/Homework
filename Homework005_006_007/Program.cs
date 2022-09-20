void Second_number()
{
    Console.WriteLine("Введите трехзначное число: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 100 && number < 1000)
    {
        Console.WriteLine("Вторая цифра введенного трехзначного числа: " + number / 10 % 10);
    }
    else
    {
        Console.WriteLine("Введено не трехзначное число. Попробуйте снова.");
    }
}

void Third_Digit()
{
    Console.WriteLine("Введите число: ");
    string number_text = Convert.ToString(Console.ReadLine());
    if (number_text.Length > 2)
    {
        Console.WriteLine("Третья цифра введенного числа: " + number_text[2]);
    }
    else
    {
        Console.WriteLine("У введеного числа нет третьей цифры.");
    }
}

void Day_Off()
{
    Console.WriteLine("Введите цифру, обозначающую день недели: ");
    int day_week = int.Parse(Console.ReadLine());
    if (day_week == 6 || day_week == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else
    {
        if (day_week < 1 || day_week > 7)
        {
            Console.WriteLine("Введенное число не соотвествует дню недели. Попробуйте еще раз");
        }
        else
        {
            Console.WriteLine("Этот день не является выходным");
        }
    }
}

Console.WriteLine("Введите номер задания:");
while (true)
{
    int exercise = int.Parse(Console.ReadLine());
    if (exercise == 1)
    {
        Second_number();

    }
    if (exercise == 2)
    {
        Third_Digit();

    }
    if (exercise == 3)
    {
        Day_Off();

    }
return ;
}
