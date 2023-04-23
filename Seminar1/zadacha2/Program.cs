Console.WriteLine("Введите номер :");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

if(num == 1){
    Console.WriteLine("Понедельник");
}
if(num == 2){
    Console.WriteLine("Вторник");
}
if(num == 3){
    Console.WriteLine("Среда");
}
if(num == 4){
    Console.WriteLine("четверг");
}
if(num == 5){
    Console.WriteLine("Пятница");
}
if(num == 6){
    Console.WriteLine("Суббота");
}
if(num == 7){
    Console.WriteLine("Воскресенье");
}
if (num > 7){Console.WriteLine("такого дня не существует )");}

