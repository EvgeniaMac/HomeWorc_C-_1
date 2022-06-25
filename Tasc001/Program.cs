//Задача на вывод всех четных чисел от 1 до N
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while(number>1)
{
    if(number%2==0)
    {
    Console.WriteLine(number);
    number = number - 1;
    }
    number = number - 1;
}
