using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    static class KinoLottery
    {

        private static readonly Random lotteryRandomFlag = new Random();
        private static int minNumber = 1;
        private static int maxNumber = 81;

        private static int CalcRandomNumbers()
        {
            return lotteryRandomFlag.Next(minNumber, maxNumber);
        }

        public static int GetRandomNumbers()
        {
            return CalcRandomNumbers();
        }

    }
}
