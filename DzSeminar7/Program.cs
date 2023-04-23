Start();

void Start()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    
    int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
    PrintMatrix(matrix);
    int[] avg = MeanColum(matrix);
    Console.WriteLine("Среднее арифметическое по столбцам массива");
    Console.WriteLine();
    Print1DArr(avg);
    NumberSearch(matrix);
  
    
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
// Поиск элемента в массиве


void NumberSearch(int[,] matrix)
{
    int Element = SetNumber("Число для поиска");
    int m = 0, n = 0;
    bool f = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (Element == matrix[i, j]) { m = i; n = j; f = true; };
            Console.Write("{0}\t", matrix[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    if (f)
        Console.WriteLine($"Число найдено. Строка {m + 1} Столбец {n + 1}");
    else
        Console.WriteLine("Число не найдено");

    Console.ReadKey();
}

// Поиск среднего арифметического по столбцам

int[] MeanColum(int[,] matrix)
{
    int[] means = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            means[i] = means[i] + matrix[j, i];
        }
        means[i] = means[i] / matrix.GetLength(0);
    }
    return means;
}
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}