﻿double balance = 1000;
Console.WriteLine("Balance is " + balance);
do
{

    Console.WriteLine("Enter a bet");
    double bet = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter number from 1 to 6 ");
    double a = Convert.ToDouble(Console.ReadLine());// 
    Random rnd = new Random();
    int value = rnd.Next(1, 6);
    Console.WriteLine("Digit on cube 1: " + value);
    Random r2d = new Random();
    int value2 = r2d.Next(1, 6);
    Console.WriteLine("Digit on cube 2: " + value2);

    Console.WriteLine();
    double rand = value;
    double ra2d = value2;
    if ((a == rand) | (a == ra2d))
    {
        Console.WriteLine("Congratulations you won the jackpot");
        balance = balance + (bet * a);
    }
    else
    {
        {
            if ((rand + ra2d) % 2 == 0)
            {
                balance = balance + bet;
            }
            else
            {
                balance = balance - bet;
            }
        }
    }
    Console.WriteLine("Balance is " + balance);
} while (balance > 0);
Console.WriteLine("You lose :(");