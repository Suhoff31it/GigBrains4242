Console.Write("Enter number x :");
int numX = int.Parse(Console.ReadLine());

Console.Write("Enter number y :");
int numY = int.Parse(Console.ReadLine());
if(numX>0 && numY>0)
{
    Console.WriteLine("Section 1");
}
else if (numX<0 && numY<0)
{
    Console.WriteLine("Section 3");
}
else if (numX<0 && numY>0)
{
    Console.WriteLine("Section 2");
}
else if (numX>0 && numY<0)
{
    Console.WriteLine("Section 4");
}