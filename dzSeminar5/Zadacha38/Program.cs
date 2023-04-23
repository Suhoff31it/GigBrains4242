//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(length, min, max);

Console.WriteLine($"[{string.Join(",", Array)}] ");
FindDifference(Array, max, min);

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
void FindDifference(int[] MyArray, int minVal, int maxVal) 
{ 
    for (int i = 0; i < MyArray.Length; i++) 
    { 
        if (MyArray[i] < minVal) 
        { 
            minVal = MyArray[i];
        } 
        if (MyArray[i] > maxVal) 
        { 
            maxVal = MyArray[i]; 
        } 
    }
    Console.WriteLine($"Максимальное значение: {maxVal}");
    Console.WriteLine($"Минимальное значение: {minVal}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами {maxVal - minVal}"); 
}