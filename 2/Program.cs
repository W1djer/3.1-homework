Console.WriteLine("Введите 3 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(a > b)
    max = a;
else
    max = b;

if(max > c)
    Console.Write($"Максимальное {max}");
else
{
    max = c;
    Console.Write($"Максимальное {max}");
}