//Напишите программу, которая по заданному 
//номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).

System.Console.Write("Введите номер четверти :");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x>0 , y> 0 ");
}
 else if (num == 2)
{
    Console.WriteLine("x<0 , y> 0 ");
}
 else if (num == 3)
{
    Console.WriteLine("x < 0 , y < 0 ");
}
 else if (num == 4)
{
    Console.WriteLine("x > 0 , y < 0 ");
}
else {
    Console.WriteLine(" Такой четверти нет");
}

Console.Clear();

Console.WriteLine("Enter number of quter");
     num =int.Parse(Console.ReadLine());
    
    switch(num)
    {
        case 1:Console.WriteLine("X>0, Y>0");break;
        case 2:Console.WriteLine("X<0, Y>0");break;
        case 3:Console.WriteLine("X<0, Y<0");break;
        case 4:Console.WriteLine("X>0, Y<0");break;
        default:Console.WriteLine("Wrong quoter num");break;
        
    }