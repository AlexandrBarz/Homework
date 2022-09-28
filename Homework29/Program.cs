// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
