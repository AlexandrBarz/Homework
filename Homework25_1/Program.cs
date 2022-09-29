// Написать калькулятор с операциями +, -, /, * и возведение в степень
double ReadData(string msg)
{
    Console.Write(msg);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

Console.WriteLine(@"Выбирете арифмитическую операцию:
    +  сложение
    -  вычитание
    *  умножение
    /  деление
    ^  возведение в степень");
string oper = Console.ReadLine();
if (oper != "+" && oper != "-" && oper != "*" && oper != "/" && oper != "^")
{
    Console.WriteLine("Данной операции нет в калькуляторе.");
}
else
{
    double c = 0;
    double a = ReadData("Введите первое число: ");
    double b = ReadData("Введите второе число: ");
    if (oper == "+")
    {
        Console.WriteLine($"Результат арифметической операции: {a} {oper} {b} = {a + b}");
    }
    else
    {
        if (oper == "-")
        {
            Console.WriteLine($"Результат арифметической операции: {a} {oper} {b} = {a - b}");
        }
        else
        {
            if (oper == "*")
            {
                Console.WriteLine($"Результат арифметической операции: {a} {oper} {b} = {a * b}");
            }
            else
            {
                if (oper == "/")
                {
                    Console.WriteLine($"Результат арифметической операции: {a} {oper} {b} = {a / b}");
                }
                else
                {
                    if (oper == "^")
                    {
                        Console.WriteLine($"Результат арифметической операции: {a} ^ {b} = {Math.Pow(a, b)}");
                    }
                }
            }
        }
    }
}