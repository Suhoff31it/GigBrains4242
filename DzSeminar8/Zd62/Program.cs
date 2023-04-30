Main();
 int[,] Fill(int[,] array)
 {
        var SizeX = array.GetUpperBound(0);
        var SizeY = array.GetUpperBound(1);
        var maxX = SizeX + 1;
        var maxY = SizeY;
        var dirX = 1;
        var dirY = 1;

        var x = -1;
        var y = 0;
        var val = 1;
        while ((maxX >= 0) && (maxY >= 0))
        {
            for (int xval = 1; xval <= maxX; xval++)
            {
                array[x + dirX * xval, y] = val;
                val++;
            }

            x = x + dirX * maxX;
            dirX = -dirX;
            maxX--;

            for (int yval = 1; yval <= maxY; yval++)
            {
                array[x, y + dirY * yval] = val;
                val++;
            }

            y = y + dirY * maxY;
            dirY = -dirY;
            maxY--;
        }

        return array;
 }
 void PrintArray(int[,] array)
    {

        for (int y = 0; y <= array.GetUpperBound(1); y++)
        {
            for (int x = 0; x <= array.GetUpperBound(0); x++)
                Console.Write(" 0" + array[x, y]);
            Console.WriteLine();
        }
    }
 void Main()
 {
    int a = SetNumber("размерность массива");
    var z = new int[a, a];
        z = Fill(z);
    PrintArray(z);
 }
int SetNumber(string numberName)
{
    Console.Write($" {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}