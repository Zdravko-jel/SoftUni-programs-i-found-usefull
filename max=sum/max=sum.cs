int n = int.Parse(Console.ReadLine());
int sum = 0;
int max = int.MinValue;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum = sum + num;

    if (num > max)
    {
        max = num;
    }
}
int sumwithoutmax = sum - max;
if (max == sumwithoutmax)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}
else
{
    int diff = Math.Abs(max - sumwithoutmax);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}