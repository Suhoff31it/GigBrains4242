/* Напишите программу, которая 
    принимает на вход число (N) и
    выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

Console.WriteLine("Ведите чило");
int input1 = int.Parse(Console.ReadLine());
for (int i = 1; i <= input1; i++)
{
    Console.Write($" {i * i} ");
}
