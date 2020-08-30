using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    interface IKino
    {
        int moneyBet { get; set; }
        int numberOfDraws { get; set; }
        int totalEarnings { get; set; }

        void ShowDrawNumbers();
        void CalcEarnings();
        void RunDraw();
    }
    public class KinoRound : IKino
    {
        public int moneyBet { get; set; }
        public int numberOfDraws { get; set; }
        public int totalEarnings { get; set; }

        private List<int> DrawNumbers;


        public void CalcEarnings()
        {
            totalEarnings = 0;
            int even = 0;
            int only = 0;

            foreach (var item in DrawNumbers)
            {
                if (item % 2 == 0)
                    only++;
                else
                    even++;
            }

            if (KinoPlayer.DrawPicksCharacter == "even")
            {
                if (even > only)
                    totalEarnings += moneyBet * 2;
            }
            else if (KinoPlayer.DrawPicksCharacter == "only") {
                if (only > even)
                    totalEarnings += moneyBet * 2;
            } else
            {
                if (only == even)
                    totalEarnings += moneyBet * 4;
            }

        }

        public void RunDraw()
        {
            DrawNumbers = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                DrawNumbers.Add(KinoLottery.GetRandomNumbers());
            }
        }

        public void ShowDrawNumbers()
        {
            Console.WriteLine();
            Console.WriteLine("Draw numbers are: ");
            foreach (var item in DrawNumbers)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
