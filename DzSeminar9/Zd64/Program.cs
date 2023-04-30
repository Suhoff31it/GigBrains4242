//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int M = AskNum("M");
int N = AskNum("N");
Console.WriteLine($"M = {M}; N = {N}. -> \"{PrintRange(M, N)}\"");

string PrintRange(int M, int N)
{
    if (N < M)
    {
        return "";
    }
    string part = N == M ? $"{N}" : $"{N}, ";
    return part + PrintRange(M, N - 1);
}

int AskNum(string name)
{
    Console.Write($"Введите число {name}: ");
    return int.Parse(Console.ReadLine());
}