int ThirdDigit(int number)
{
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        int result = number % 10;
    }
    else
    {
        int result = -1; // [B] Переменной "result" присвоено значение но оно ниразу не используется[/B]
    }

    return result; // [B]имя "result" не существует в текущем контексте[/B]
}

Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
    Console.WriteLine("третьей цифры нет");
else
    Console.WriteLine($"Third digit is {ThirdDigit(number1)}");