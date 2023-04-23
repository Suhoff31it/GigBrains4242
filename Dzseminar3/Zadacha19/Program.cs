/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
  является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
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