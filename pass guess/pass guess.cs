string user = Console.ReadLine();
string pass = new string(user.Reverse().ToArray());

int loginatempts = 0;

while (true)
{
    string guess = Console.ReadLine();

    if (guess == pass)
    {
        Console.WriteLine($"User {user} logged in.");
        return;
    }
    else
    {
        loginatempts++;
        Console.WriteLine($"Incorrect password. Try again.");
    }

    if (loginatempts == 4)
    {
        Console.WriteLine($"User {user} blocked!");
        break;
    }
}