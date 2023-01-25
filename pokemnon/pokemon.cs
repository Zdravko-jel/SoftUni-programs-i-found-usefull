int N = int.Parse(Console.ReadLine());
int N1 = N;
int M = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int count = 0;

while (N > M)
{
    N = N - M;
    count++;
    if (N == N1 / 2)
    {
        N = N / Y;
    }
}

Console.WriteLine($"{N}");
Console.WriteLine($"{count}");