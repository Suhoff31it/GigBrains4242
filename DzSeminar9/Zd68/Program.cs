// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.



int M = AskNum("M");
int N = AskNum("N");
Console.WriteLine($"M = {M}; N = {N} -> A(m,n) = {Akerman(M, N)}");

int Akerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return Akerman(n - 1, 1);
    else
        return Akerman(n - 1, Akerman(n, m - 1));
}

int AskNum(string name)
{
    Console.Write($"Введите число {name}: ");
    return int.Parse(Console.ReadLine());
}


