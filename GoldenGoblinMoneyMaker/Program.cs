using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Golden Goblin Money Maker! Your gold is welcome here.");
            Console.WriteLine("With the Duke's tax increase, gold coins are now worth 10 broze, and the silver coins are now worth 5 bronze. But that shouldn't slow you down!");
            //Greet the user and demand input
            Console.WriteLine("Enter an amount to convert to coinage: ");
            string totalAsString =
            Console.ReadLine();
            double total = Convert.ToDouble(totalAsString);

            Console.WriteLine($"{total}! What an interesting amount. I believe that is equal to...");

            //now to define coin values

            int goldValue = 10;
            int silverValue = 5;
            //no need to define the bronze, 1 cent coins, that can be given just by the remainder
            //calculate the changes
            double goldCoins = Math.Floor(total / goldValue);
            //next part is to find what's left over
            double remainder = total % goldValue;


            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            //Print the results!

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
            Console.WriteLine("What a mighty coinpurse you have. Make sure to spend it all here!");

        }
    }
}
