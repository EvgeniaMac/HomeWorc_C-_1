//Задача на определение максимального числа из 3-х
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(number1>number2)
{
    if(number1>number3)
    {
        max = number1;
        Console.WriteLine("Максиум:");
        Console.WriteLine(max);    
    }
}
else{    
if(number2>number3)
{
    max = number2;
    Console.WriteLine("Максиум:");
    Console.WriteLine(max);   
}   
max = number3;
Console.WriteLine("Максиум:");
Console.WriteLine(max); 
}

