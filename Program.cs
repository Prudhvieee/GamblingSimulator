using System;

namespace GamblingSimulator
{
    public class Program
    {
        //Declaring initial Variables
        private static int moneyAtStart = 100;
        private static int betAmt = 1;
        private static int gamblingMoney = moneyAtStart;
        private static int winCounter = 0;
        private static int lossCounter = 0;
        private static int dayBetCount = 0;
        private static int lossAmount = 0;
        private static int profitAmount = 0;
        private static double stakePercent = 0.50;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Simulator");
            gameFor20Days();
        }
        /// <summary>
        /// UC-2
        /// This method generates random value and calculates the gambler win or loose
        /// </summary>
        public static void gambling()
        {
            Random random = new Random();
            var number = random.Next(0, 2);
            if (number == 1)
            {
                gamblingMoney += betAmt;
            }
            else if (number == 0)
            {
                gamblingMoney -= betAmt;
            }
        }
        /// <summary>
        /// UC-3
        /// </summary>
        public static int PlayForTheDay()
        {
            int stakeValue = (int)(stakePercent * moneyAtStart);
            int winningStake = (int)(moneyAtStart + stakeValue);
            int losingStake = (int)(moneyAtStart - stakeValue);
            bool flag = true;
            while (flag)
            {
                gambling();
                dayBetCount++;
                if (gamblingMoney == losingStake)
                {
                    lossAmount += gamblingMoney;
                    flag = false;
                    winCounter++;
                }
                else if (gamblingMoney == winningStake)
                {
                    profitAmount += gamblingMoney;
                    flag = false;
                    lossCounter++;
                }
            }
            return dayBetCount;
        }
        /// <summary>
        /// UC-4
        /// method for playing game for 20 days
        /// </summary>
        public static void gameFor20Days()
        {
            int i = 1;
            while (i <= 20)
            {
                PlayForTheDay();
                if (i >=20)
                {
                    Console.WriteLine($"\nDay {i} \nTotal Profit: { profitAmount} \nTotal Loss:  {lossAmount} \n wins: {winCounter}\n loose : {lossCounter}");
                }
                i++;
            }
        }
    }
}
