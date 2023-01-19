int n = int.Parse(Console.ReadLine());
int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num < 200)
    {
        p1 += 1;
    }
    else if (num < 400)
    {
        p2 += 1;
    }
    else if (num < 600)
    {
        p3 += 1;
    }
    else if (num < 800)
    {
        p4 += 1;
    }
    else
    {
        p5 += 1;
    }
}

Console.WriteLine($"{p1 * 1.0 / n * 100:f2}%");
Console.WriteLine($"{p2 * 1.0 / n * 100:f2}%");
Console.WriteLine($"{p3 * 1.0 / n * 100:f2}%");
Console.WriteLine($"{p4 * 1.0 / n * 100:f2}%");
Console.WriteLine($"{p5 * 1.0 / n * 100:f2}%");