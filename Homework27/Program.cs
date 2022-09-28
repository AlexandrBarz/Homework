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

//int number = ReadData("Введите число: ");
//int sum = 0;
//if (number < 0) number *= -1;
//while (number > 0)
//{
//    int res = number % 10;
//    sum = sum + res;
//    number = number / 10;
//}
//PrintData("Сумма чисел введенного числа = ", sum);

//Тоже решение только с использованием строки

int number = ReadData("Введите число: ");
//int sum = 0;
string str = number.ToString();
string[] strarr = new string[str.Length];
int[] ints = Array.ConvertAll(strarr, int.Parse);
Console.WriteLine(ints[1]);
//int[] intiger = Array.ConvertAll(strnum, int.Parse);
//for(int i=0;i<arrnum.Length-1;i++)
//sum=sum+arrnum[i];
//Console.WriteLine(strnum);
//PrintData("Сумма чисел введенного числа = ", strnum);