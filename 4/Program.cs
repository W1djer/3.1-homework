Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N > 0)
{
    for(int i = 2; i < N; i = i + 2)
        Console.Write(i +" ");
}
else
{
    for(int i = -2; i > N; i = i - 2)
        Console.Write(i +" ");
}