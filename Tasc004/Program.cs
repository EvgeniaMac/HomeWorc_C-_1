//Задача на определение максимального числа из 3-х
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(namber1>namber2)
{
    if(namber1>namber3)
    {
        max = number1;
        Console.WriteLine("Максиум:");
        Console.WriteLine(max);    
    }
}
else
if(namber2>namber3)
{
    if(namber2>namber1)
    {
        max = number2;
        Console.WriteLine("Максиум:");
        Console.WriteLine(max);    
    }
    else
    if(namber3>namber1)
    {
        max = number3;
        Console.WriteLine("Максиум:");
        Console.WriteLine(max);    
    }
}