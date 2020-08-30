using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    static class KinoPlayer
    {

        private static string drawPicksCharacter; 
        public static string DrawPicksCharacter { get { return drawPicksCharacter; } private set { } }

        private static int playerTotalEarnings; 
        public static int PlayerTotalEarnings { get { return playerTotalEarnings; } set { } }

        private static bool hasPlayed = false;
        public static bool HasPlayed { get { return hasPlayed; } set { } }

        public static void GetDrawPicksCharacter()
        {
            drawPicksCharacter = Helper.GetString("DRAW if you bet for draw numbers, ONLY if you bet for only numbers, EVEN if you bet for even numbers ");
        }

        public static void CalcPlayerTotalEarnings(int totalEarnings)
        {
            playerTotalEarnings += totalEarnings;
        }

        public static void ShowRoundEarnings(int totalEarnings)
        {

            if (totalEarnings > 0)
                Console.WriteLine($"Congrats! You won this round! Your earnings are: {totalEarnings}");
            else
                Console.WriteLine("What a bummer! You lost this round!");
        }

        public static void HasPlayedTrue()
        {
            hasPlayed = true;
        }

    }
}
