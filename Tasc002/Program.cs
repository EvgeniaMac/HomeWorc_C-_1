// задача наопределение четное или нечетное число

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 ==0)
{
    Console.WriteLine("Вы ввели четное число");
}
else{
    Console.WriteLine("Вы ввели нечетноее число");
}