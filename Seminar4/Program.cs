int SetNumber(string text = "")
{
    Connsole.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;

}
int num = SetNumber();
int sum = 0;
for (int i = 1; i <= num; ++i)
{
    sum += i;
}
System.Console.WriteLine("sum = " + sum);

Console.Clear();