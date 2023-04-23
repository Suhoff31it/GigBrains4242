Console.WriteLine("Введите номер дня недели :");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

if (num > 5 && num <8)
{
    Console.WriteLine("Выходной");
}
else if(num >0 && num <= 5)
{
    Console.WriteLine("Рабочий день");
}
else if (num > 7)
{
    Console.WriteLine("Не явдяется днем недели");
}