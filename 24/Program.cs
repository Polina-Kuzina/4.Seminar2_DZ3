//24. Найти кубы чисел от 1 до N
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());


for (int x = 1; x <= N; x++)
{
    Console.WriteLine($"{x} x {x} x {x} = {x*x*x}");
}
