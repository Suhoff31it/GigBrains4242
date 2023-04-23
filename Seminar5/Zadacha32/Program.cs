// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество  
// элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 12
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

// int size = 12;
// int[] nums = GetArray(size);
// Console.WriteLine(string.Join("; ", nums));

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//         result[i] = rnd.Next(0, 200);

//     return result;
// }
// int SumNumPlus(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i] > 0)
//         {
//             result = result + array[i];
//         }
//     }
//     return result;
// }
/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
int[] FillArray (int length, int minValue, int maxValue)
{
    int [] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
        result[i] = rand.Next(minValue, maxValue + 1);
    return result;
} 

int [] GetNewArray (int[] array)
{
    int [] mult = new int[array.Length / 2];
    
    for (int i = 0; i < mult.Length; i++)
        mult[i] = array[i] * array[array.Length - 1 - i];
       
    return mult;
}


// int[] array = FillArray (12, 0, 10);
// Console.Clear();
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", GetNewArray(array)));

// int[] FillArray(int length, int minValue, int maxValue)
// {
//     int[] result = new int[length];
//     Random rand = new Random();
//     for (int i = 0; i < length; i++)
//         result[i] = rand.Next(minValue, maxValue + 1);
//     return result;
// }

// int[] GetNewArray(int[] array)
// {
//     int size = array.Length % 2 == 0 ? array.Length / 2 : (array.Length / 2) + 1;
//     int[] mult = new int[size];

//     for (int i = 0; i < mult.Length; i++)
//        mult[i] = array[i] * array[array.Length - 1 - i];
       
//     if (array.Length % 2 == 1) mult[size-1] = array[array.Length / 2];
//     return mult;
// }


// int[] array = FillArray(11, 0, 10);
// Console.Clear();
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", GetNewArray(array)));