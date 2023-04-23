/*Напишите программу, которая принимает 
на вход координаты двух точек и находит
 расстояние между ними в 2D пространстве.
 
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

Console.WriteLine(" X кординатf первой точки");
int x1 =int.Parse(Console.ReadLine());
Console.WriteLine(" Y кординатf первой точки");
int y1 =int.Parse(Console.ReadLine());
Console.WriteLine("X кординаты второй точки");
int x2 =int.Parse(Console.ReadLine());
Console.WriteLine("Y кординаты второй точки");
int y2 =int.Parse(Console.ReadLine());

double skalar = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
Console.WriteLine(skalar);

int num, rem, sum = 0, temp; 
Console.Write("\n Enter a number: "); 
num = Convert.ToInt32(Console.ReadLine()); 
temp = num; 
while (Convert.ToBoolean(num)) 
{
rem = num % 10; num = num / 10; sum = sum * 10 + rem;
} 
Console.WriteLine("\n The Reversed Number is: {0} \n", sum); 
if (temp == sum) 
{
    Console.WriteLine("\n Number is Palindrome \n\n");
} 
else
{
    Console.WriteLine("\n Number is not a palindrome \n\n");
    }