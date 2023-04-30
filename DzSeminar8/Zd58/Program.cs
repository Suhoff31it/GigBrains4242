
Console.WriteLine("Введите размеры матриц и их диапозон:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] OneMartrix = new int[m, n];
GetRandomMatrix(OneMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(OneMartrix);

int[,] TwoMartrix = new int[n, p];
GetRandomMatrix(TwoMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(TwoMartrix);

int[,] resultMatrix = new int[m, p];

CompositionArray(OneMartrix, TwoMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void GetRandomMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void CompositionArray(int[,] OneMartrix, int[,] TwoMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < OneMartrix.GetLength(1); k++)
            {
                sum += OneMartrix[i, k] * TwoMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}