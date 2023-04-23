/*System.Console.WriteLine("Введите число: ");
int num = Convert.Toint32(Console.RedLine());
int i=0;
for ( ; num > 0; num /= 10)
{
    i++;
}
System.Console.WriteLine(i);*/


/*void methodArray(int[] array)
{
    int length = array.Length;
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = new rand.Next(2);

    }
}
void print(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] array = new int[8];
methodArray(array);
print(array);*/
void FillArray (int [] array)
{
   int lentgh = array.Length;
   Random rand = new Random ();
   for(int i = 0; i < lentgh; i++) 
   {
    array[i] = rand.Next(2);
   }
}
void PrintArray (int [] array)
{
    int lentgh = array.Length;
   for(int i = 0; i < lentgh; i++) 
   {
    Console.Write(array [i] + " ");
   }
}
int [] array = new int[8];  
FillArray(array);
PrintArray(array);