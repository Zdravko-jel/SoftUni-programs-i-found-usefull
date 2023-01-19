int n = int.Parse(Console.ReadLine());

bool number = false;
int count = 0;

for (int a = 1; a <= 9; a++)
{
    for (int b = 9; b >= a; b--)
    {
        for (int c = 0; c <= 9; c++)
        {
            for (int d = 9; d >= c; d--)
            {
                int suma = a + b + c + d;
                int umn = a * b * c * d;
                if (suma == umn && n % 10 == 5)
                {
                    count++;
                    Console.WriteLine($"{a}{b}{c}{d}");
                    number = true;
                    break;
                }
                else if (umn / suma == 3 && n % 3 == 0)
                {
                    count++;
                    Console.WriteLine($"{d}{c}{b}{a}");
                    number = true;
                    break;
                }
            }
            if (number)
            {
                break;
            }
        }
        if (number)
        {
            break;
        }
    }
    if (number)
    {
        break;
    }
}
if (count == 0)
{
    Console.WriteLine("Nothing found");
}
