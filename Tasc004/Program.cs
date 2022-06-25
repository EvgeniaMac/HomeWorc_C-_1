Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;

if(number1>number2)
{
    max = number1;
    Console.WriteLine("Максиум:");
    Console.WriteLine(max);
    min = number2;
    Console.WriteLine("Минимум:");
    Console.WriteLine(min);
}
else{
max = number2;
Console.WriteLine("Максиум:");
Console.WriteLine(max);
min = number1;
Console.WriteLine("Минимум:");
Console.WriteLine(min);
}
