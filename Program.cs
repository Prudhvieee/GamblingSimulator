using System;

namespace GamblingSimulator
{
    public class Program
    {
        //Declaring initial Variables
        private static int moneyAtStart = 100;
        private static int betAmt = 1;
        private static int gamblingMoney = moneyAtStart;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Simulator");
            gamble();
        }
        /// <summary>
        /// UC-2
        /// This method generates random value and calculates the gambler win or loose
        /// </summary>
        public static void gambling()
        {
            Random random = new Random();
            var n = random.Next(0, 2);
            if (n == 1)
            {
                gamblingMoney += betAmt;
            }
            else if (n == 0)
            {
                gamblingMoney -= betAmt;
            }
        }
        /// <summary>
        /// UC-3
        /// </summary>
        public static void gamble()
        {
            bool flag = true;
            while (flag)
            {
                gambling();
                if (gamblingMoney == 50)
                {
                    flag = false;
                    Console.WriteLine("Lost the game" + " " + gamblingMoney);
                }
                else if (gamblingMoney == 150)
                {
                    flag = false;
                    Console.WriteLine("Win the game" + " " + gamblingMoney);

                }
            }
        }
    }
}
