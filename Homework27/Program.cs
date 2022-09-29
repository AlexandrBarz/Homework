// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числe, через int и *string. *Сделать оценку времени алгоритма.
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

Console.WriteLine("Метод 1 через int");
int number = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
int sum = 0;
if (number < 0) number *= -1;
while (number > 0)
{
    int res = number % 10;
    sum = sum + res;
    number = number / 10;
}
PrintData("Сумма чисел введенного числа = ", sum);
Console.WriteLine(DateTime.Now - d1);

Console.WriteLine("Метод 2 через string");
Console.Write("Введите число: ");
string numstr = Console.ReadLine();
DateTime d2 = DateTime.Now;
char[] strarr = numstr.ToCharArray();
int sum1 = 0;
for (int i = 0; i < strarr.Length; i++)
{
    int digit = strarr[i] - '0';
    sum1 = sum1 + digit;
}
PrintData("Сумма чисел введенного числа = ", sum1);
Console.WriteLine(DateTime.Now - d2);
if ((DateTime.Now - d1) < (DateTime.Now - d2))
{
    Console.WriteLine("Метод 1 (int) быстрее, чем Метод 2 (string)");
}
else 
{
    Console.WriteLine("Метод 2 (string) быстрее, чем Метод 1 (int)");
}