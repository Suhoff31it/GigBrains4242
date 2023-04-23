/*/Задача 48: Задайте двумерный массив 
 * размера m на n, каждый элемент в массиве
 * находится по формуле: Aₘₙ = m+n. Выведите
 * полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/
/*
void PrinNumber(int[,]matr)
{
  for(int i = 0;i < matr.GetLength(0);i++)
  {
      for(int j = 0;j < matr.GetLength(1); j++)
      {
          Console.WriteLine($"{matr[i,j]}");
      }
      Console.WriteLine();
  }
}
void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          matr[i, j] = i + j;
      }
  }
  Console.Clear();
  int[,] matrix = new int[3, 4];
  FillArray(matrix);
  PrinNumber(matrix);*/




/*Задача 49: Задайте двумерный массив. 
 * Найдите элементы, у которых оба индекса чётные,
 * и замените эти элементы на их квадраты.*/

/*
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
        int[,] arr = new int[ylen, xlen];
        for (int i = 0; i < ylen; i++)
        {
            for (int j = 0; j < xlen; j++)
            {
                arr[i, j] = j + i;
            }
        }
        return arr;
}

void Print2DArr(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine("");
        }
    }

void Update2DArr(int[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i = i + 2)
        {
            for (int j = 0; j < arr.GetLength(1); j = j + 2)
            {
              
                arr[i, j] = (int)Math.Pow(arr[i, j], 2);
            }
        }
}
int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
Update2DArr(matrix);
Console.WriteLine();
Print2DArr(matrix);*/


/*Задайте двумерный массив. 
    Найдите сумму элементов, 
    находящихся на главной диагонали 
    (с индексами (0,0); (1; 1) и т.д.*/

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j + i;
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int DiagSum(int[,] arr)
{
    int res = 0;
    int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);

    for (int i = 0; i < min; i = i + 1)
    {
        res = res + arr[i, i];
    }
    return res;
}


int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
int sumOfDiagonal = DiagSum(matrix);
Console.WriteLine($"Сумма элементов главной диогонали={sumOfDiagonal}");