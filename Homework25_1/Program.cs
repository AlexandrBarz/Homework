// Написать калькулятор с операциями +, -, /, * и возведение в степень
double ReadData(string msg)
{
    Console.Write(msg);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

void Calc(double FisrtVar, double SecondVar)
{
    Console.WriteLine(@"Выбирете арифмитическую операцию:
    + : сложение
    - : вычитание
    * : умножение
    / : деление
    ^ : возведение в степень");
    string oper = Console.ReadLine();
    while (oper == "+" || oper == "-" || oper == "*" || oper == "/" || oper == "^")
    {
        double c = 0;
        if (oper == "+") Console.WriteLine($"Результат арифметической операции: {FisrtVar} {oper} {SecondVar} = {FisrtVar + SecondVar}");
        if (oper == "-") Console.WriteLine($"Результат арифметической операции: {FisrtVar} {oper} {SecondVar} = {FisrtVar - SecondVar}");
        if (oper == "*") Console.WriteLine($"Результат арифметической операции: {FisrtVar} {oper} {SecondVar} = {FisrtVar * SecondVar}");
        if (oper == "/") Console.WriteLine($"Результат арифметической операции: {FisrtVar} {oper} {SecondVar} = {FisrtVar / SecondVar}");
        if (oper == "^") Console.WriteLine($"Результат арифметической операции: {FisrtVar} {oper} {SecondVar} = {Math.Pow(FisrtVar, SecondVar)}");
        return;
        Console.WriteLine("Данной операции нет в калькуляторе.");
    }
}

double a = ReadData("Введите первое число: ");
double b = ReadData("Введите второе число: ");
Calc(a, b);