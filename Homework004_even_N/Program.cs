Console.WriteLine("Введите число N для нахождения четных чисел от 1 до N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Четные числа в ряду от 1 до " + N);
int number = 1;

while (number <= N)
{   
    if (number % 2 == 0)
    {
        Console.Write(number + " ");
    }
    number++;
}
