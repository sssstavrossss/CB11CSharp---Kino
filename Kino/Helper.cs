using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    static class Helper
    {
        public static List<int> Bets = new List<int>() { 1, 2, 3, 5, 10, 15, 20, 30, 50, 100 };
        public static List<int> DrawPicks = new List<int>() { 1, 2, 3, 4, 6, 10, 20, 50, 100, 200 };

        public static int GetNumber(int key)
        {
            int number = -1;
            string str_number;
            bool flag = true;

            do
            {
                if (key == 1)
                    Console.WriteLine("Type: 1. Yes - Play the game, 0. No - Exit App");
                else if (key == 2)
                    Console.WriteLine("Are you sure you want to Exit the App? Type: 1. No - Continue playing, 0. Yes - Exit App");
                else if (key == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Type your bet: ");
                    foreach (var item in Helper.Bets)
                        Console.Write($"{item} ");
                    Console.WriteLine();
                }
                else {
                    Console.WriteLine();
                    Console.WriteLine("Type how many rounds you want to play: ");
                    foreach (var item in Helper.DrawPicks)
                        Console.Write($"{item} ");
                    Console.WriteLine();
                }

                str_number = Console.ReadLine();
                int.TryParse(str_number, out number);
                

                if (key == 1 || key == 2)
                    flag = (number == 1 || number == 0);
                else if (key == 3)
                    flag = (Bets.Contains(number));
                else
                    flag = (DrawPicks.Contains(number));

            } while (!flag);

            return number;
        }

        public static string GetString(string message)
        {
            string str;
            bool flag;
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Please type: {message}");
                str = Console.ReadLine().Trim().ToLower();
                flag = (str == "draw" || str == "even" || str == "only");
            } while (!flag);
            return str;
        }

    }
}
