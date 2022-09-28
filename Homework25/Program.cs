// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double ReadData(string msg)
{
    Console.Write(msg);
    double number = Convert.ToDouble(Console.ReadLine() ?? "0");
    return number;
}

int PowAtoB(int a, int b)
{
    int result = (int)Math.Pow(a, b);
    return result;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

double numberA = ReadData("Ввведите число А: ");
double numberB = ReadData("Ввведите число B: ");
double integer = Math.Truncate(numberB);
if ((numberB >= 1) && (numberB - integer) == 0)
{
    int intnumA = Convert.ToInt32(numberA);
    int intnumB = Convert.ToInt32(numberB);
    int result = PowAtoB(intnumA, intnumB);
    PrintData("Итог возведения числа " + numberA + " в степень " + numberB + " равен ", result);
}
else
{
    Console.WriteLine("Введенное число " + numberB + " не является натуральным. Введите натуральное число!");
}