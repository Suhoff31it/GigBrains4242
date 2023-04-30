Start();

void Start()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    int min = SetNumber("min");
    int max = SetNumber("max");
    int[,] matrix = GetRandomMatrix(rows, columns, min, max);
    PrintMatrix(matrix);
    Console.WriteLine();
    int Line = SumLine(matrix);
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов в {Line} строке");




}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }

    return array;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}

int SumLine(int[,] array2D)
{
    int[] sumArr = new int[array2D.GetLength(0)];
    Console.Write($"Суммы строк:");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sumArr[i] += array2D[i, j];
        }
        Console.Write($" {sumArr[i]}");
    }
    Console.WriteLine();
    int minSum = sumArr[0];
    int minLine = 1;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (sumArr[i] < minSum)
        {
            minSum = sumArr[i];
            minLine = i + 1;
        }
    }
    return minLine;
}