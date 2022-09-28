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
int result = PowAtoB(numberA, numberB);
PrintData("Итог возведения числа " + numberA + " в степень " + numberB + " равен ", result);