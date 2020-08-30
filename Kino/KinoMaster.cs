using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    static class KinoMaster
    {
        public static void InitKino()
        {
            int play; // decides if player wants to play or not
            int exit = -1; // doublecheck if player wants to exit
            Console.WriteLine("Do you want to play Kino?");
            do
            {

                play = Helper.GetNumber(1); // 1. Key path for function to determine outcome
                
                if (play == 1)
                {
                    KinoPlayer.HasPlayedTrue(); // A silly method that stores true if player has played at least once, used only to show proper message at exit
                    IKino _round = new KinoRound();
                    _round.moneyBet = Helper.GetNumber(3); // 3. Key path to show / handle proper data to fill moneyBet 
                    _round.numberOfDraws = Helper.GetNumber(4); // 4. Keyp path to show / handle proper data to fill numberOfDraws
                    KinoPlayer.GetDrawPicksCharacter(); // Determine if player picked draw, noly, even

                    for (int i = 1; i <= _round.numberOfDraws; i++)
                    {
                        Console.WriteLine();
                        _round.RunDraw();
                        _round.ShowDrawNumbers();
                        _round.CalcEarnings();
                        KinoPlayer.ShowRoundEarnings(_round.totalEarnings);
                        KinoPlayer.CalcPlayerTotalEarnings(_round.totalEarnings);
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Your total earnings while you played are: {KinoPlayer.PlayerTotalEarnings - _round.totalEarnings}");
                    Console.WriteLine();
                }
                else
                    exit = Helper.GetNumber(2); // 2. Key path to show proper message and determine if user really wants to exit the app

            } while (exit != 1);

            Console.WriteLine();
            if (KinoPlayer.HasPlayed) {
                Console.WriteLine($"Your total earnings while you played are: {KinoPlayer.PlayerTotalEarnings}");
                Console.WriteLine();
            }
            Console.WriteLine("Bye Bye!");
            Console.WriteLine();

        }
    }
}
