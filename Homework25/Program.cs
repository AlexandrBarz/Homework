// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
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

int numberA = ReadData("Ввведите число А: ");
int numberB = ReadData("Ввведите число B: ");
int integer = Math.Truncate(numberB);
if (numberB > 0 && (numberB - integer) == 0)
{
   int result = PowAtoB(numberA, numberB);
}
else
{
    Console.WriteLine("Введенное число для степени не является натуральным. Введите натуральное число");
}
PrintData("Итог возведения числа " + numberA + " в степень " + numberB + " равен ", result);