Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(x > b)
{
    Console.WriteLine($"Меньшее число: {b}");
    Console.Write($"Большее число: {x}");
}
else
{
    Console.WriteLine($"Меньшее число: {x}");
    Console.Write($"Большее число: {b}");
}
