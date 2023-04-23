//Напишите программу которая перевернет одномерный массив
//(последний элемент будет на первом месте, а первый на последнем)
/*Console.Clear();
int[] array = GetArray(12, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
MyReverse2(array);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetArray(int size, int minValue, int maxValue) 
{
     int[] result = new int[size];
     Random rnd = new Random();
     for (int i = 0; i < size; i++)
         result[i] = rnd.Next(0, 200);

     return result;
 }*/

/*int[] MyReverse1(int[] array)
{ int[] reverse = new int[array.Length];
    
    for(int i=0; i<array.Length; i++)
    {
        reverse[i] = array[array.Length - 1 - i];
    }
    return reverse;
}*/

/*void MyReverse2(int[] array)
{ 
    
    for(int i=0; i<array.Length/2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    
}*/

/* Напишите программу которая на вход принимает
три числа и проверяет, может ли существовать 
треугольник с сторонами такой длины(теорема о 
неравенстве треугольника : каждая сторона треугольника 
меньше суммы двух других строн)*/


/*int[] array = new int[3];
for(int i=0;i<3;i++)
{
    Console.WriteLine("Tnter num");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
/*Console.Write("Введите Три числа (разделитель пробел): ");
int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
*/
/*bool ChekTriangle(int[] array)
{
    bool result = true;
    for (int i = 0; i < 3; i++)
    {
        result &= array[i] < array[(i + 1) % 3] + array[(i + 2) % 3];
    }
    return result;
}
string msg = ChekTriangle(array) ? "Треугольник реален" : "Ереугольник не возможен";
Console.WriteLine(msg);*/

/*Задача 42: Напишите программу, 
которая будет преобразовывать десятичное 
число в двоичное.*/



/*Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите основание системы исчисления: ");
int @base = int.Parse(Console.ReadLine());
Console.WriteLine(CheingBase(num, @base));
string CheingBase(int num, int @base)
{
    int[] array = new int[32];
    for (int i = 31; ; i--)
    {
        array[i] = num % @base;
        num/= @base;
        if (num == 0)
            break;
    }
    return String.Join("", array);
}*/
/*using System;
namespace exp42
{
    class tr
    {
        static int setVal()
        { // ввод числа
            Console.Write("Введите число : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] numToBinar(int num)
        {
            int[] bin = new int[32];
            int i = 31;
            while (num > 0)
            {
                bin[i] = num % 2;
                num /= 2;
                i--;
            }
            return bin;
        }

        static void outputArray(int n, int[] arr)
        { // вывод массива случайных чисел
            string text = "[" + string.Join(", ", arr) + "]";
            Console.WriteLine(text);
        }

        static void Main(string[] str)
        {
            //int number = setVal();
            //outputArray(32, numToBinar(number));
            outputArray(32, numToBinar(setVal())); 
        }*/

Console.Clear();
int number=int.Parse(Console.ReadLine());

string res1=Convert.ToString(number,2);
string res2=DecToNum(number,2);

Console.WriteLine($"{number}=>{res1}");
Console.WriteLine($"{number}=>{res2}");

string DecToNum(int decNumber, int otherSystem)
    {
    string res = "";
    string nums = "0123456789ABCDEF";
        while(decNumber>0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - (otherSystem * ost)] + res;
        decNumber/=otherSystem;
    }
        return res;
}