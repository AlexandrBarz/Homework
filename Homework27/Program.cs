// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

int number = ReadData("Введите число: ");
int sum = 0;
if (number < 0) number *= -1;
while (number > 0)
{
    int res = number % 10;
    sum = sum + res;
    number = number / 10;
}
PrintData("Сумма чисел введенного числа = ", sum);