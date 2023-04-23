//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(length, min, max);

Console.WriteLine($"[{string.Join(",", Array)}] ");
sumOfOdd(Array);

int[] GetArray(int length, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }
    return array;
}

int sumOfOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
Console.WriteLine($"Сумма элементов массива на нечетных позициях {sumOfOdd(Array)}");