// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.




int M = AskNum("M");
int N = AskNum("N");
Console.WriteLine($"M = {M}; N = {N} -> {PrintSum(M, N)}");

int PrintSum(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    return M + PrintSum(M + 1, N);
}

int AskNum(string name)
{
    Console.Write($"Введите число {name}: ");
    return int.Parse(Console.ReadLine());
}