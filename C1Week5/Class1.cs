using System;

namespace Week5
{
    public class MoneyChange
    {

        public int MoneyChangeRecursive(int value, int[] coins)
        {
            int minNumberofCoins = 0;
            if (value == 0)
                return minNumberofCoins;

            else
            {
                int minNum = int.MaxValue;
                foreach (var coin in coins)
                {
                    if (value >= coin)
                    {
                        int min = MoneyChangeRecursive(value - coin, coins);
                        if (min + 1 < minNum)
                        {
                            minNum = min + 1;
                        }
                    }
                }
                return minNum;
            }
        }



        public int MoneyChangeDynamic(int value, int[] coins, int[] table)
        {

            int minNumberofCoins = 0;
            if (value == 0)
            {
                if (table[0] == -1)
                {
                    table[0] = 0;
                }
                return minNumberofCoins = table[0];
            }

            else
            {
                int minNum = int.MaxValue;
                foreach (var coin in coins)
                {
                    int minimumNum;
                    if (value >= coin)
                    {
                        if (table[value - coin] == -1)
                        {
                            minimumNum = MoneyChangeDynamic(value - coin, coins, table);
                        }
                        else
                        {
                            minimumNum = table[value - coin];
                        }

                        if (minimumNum + 1 < minNum)
                        {
                            minNum = minimumNum + 1;
                        }
                    }

                }
                if (table[value] == -1)
                {
                    table[value] = minNum;
                }
                return minNum;
            }
        }



    }
}
