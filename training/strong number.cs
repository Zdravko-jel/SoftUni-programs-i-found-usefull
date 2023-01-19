using System.Diagnostics.CodeAnalysis;

int number = int.Parse(Console.ReadLine());
int copy = number;
int sym = 0;

while (copy > 0)
{
    int dig = copy % 10;
    copy = copy / 10;

    int factor = 1;
    for (int i = 1; i <= dig; i++)
    {
        factor *= i;
    }
    sym += factor;
}
if (sym == number)
{
    Console.WriteLine($"yes");
}
else
{
    Console.WriteLine($"no");
}   