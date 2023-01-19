using System;
//We create a sum in which we will store the money we are going
//to store the money we will enter and a string in which we will recieve
//either a word or a number
double sum = 0.0;
string money = Console.ReadLine();

//We create a while loop that will work until the string money becomes a "Start"
//otherwise it will just continue
//below the loop we have a switch that check if we had one of the numbers or start
//or invalid number and if we had the numbers we want it makes the string to double and
//adds it to the sum. after that it asks for another number or "Start"
while (money != "Start")
{
    switch (money)
    {
        case "0.1":
            sum = sum + double.Parse(money);
            money = Console.ReadLine();
            break;
        case "0.2":
            sum = sum + double.Parse(money);
            money = Console.ReadLine();
            break;
        case "0.5":
            sum = sum + double.Parse(money);
            money = Console.ReadLine();
            break;
        case "1":
            sum = sum + double.Parse(money);
            money = Console.ReadLine();
            break;
        case "2":
            sum = sum + double.Parse(money);
            money = Console.ReadLine();
            break;
        default:
            Console.WriteLine($"Cannot accept {money}");
            money = Console.ReadLine();
            break;
    }
}
//Console.WriteLine(sum);
//now we ask for what we want and after we recieve it we start almost the same
//while loop as before but now until we recieve "End"
//if we enter a right product it's price is taken from the sum we already
//collected and if the item is not right it asks for another one.
string want = Console.ReadLine();

while (want != "End")
{
    switch (want)
    {
        case "Nuts":
            if (sum >= 2.0)
            {
                sum = sum - 2.0;
                Console.WriteLine("Purchased nuts");
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
            }
            want = Console.ReadLine(); break;
        case "Water":
            if (sum >= 0.7)
            {
                sum = sum - 0.7;
                Console.WriteLine("Purchased water");
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
            }
            want = Console.ReadLine(); break;
        case "Crisps":
            if (sum >= 1.5)
            {
                sum = sum - 1.5;
                Console.WriteLine("Purchased crisps");
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
            }
            want = Console.ReadLine(); break;
        case "Soda":
            if (sum >= 0.8)
            {
                sum = sum - 0.8;
                Console.WriteLine("Purchased soda");
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
            }
            want = Console.ReadLine(); break;
        case "Coke":
            if (sum >= 1)
            {
                sum = sum - 1.0;
                Console.WriteLine("Purchased coke");
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
            }
            want = Console.ReadLine(); break;
        default:
            Console.WriteLine($"Invalid product");
            want = Console.ReadLine();
            break;
    }

    //in the end we print what we have left from the sum
    Console.WriteLine($"Change: {sum:f2}");
}