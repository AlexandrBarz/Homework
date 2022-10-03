// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа через запятую: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) count++;
}
Console.WriteLine($"Количество положительных чисел = {count}");