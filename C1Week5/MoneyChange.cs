using System;
using System.Diagnostics;

namespace Week5
{
    public class MoneyChange
    {

        public int MoneyChangeRecursive(int value, int[] coins)
        {
            if (value == 0)
                return 0;
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


        //Incorrect implementation of dynamic programing
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

        // Assuming all the table values are -1
        //Correct implementation of Dynamic programing
        public int MoneyChangeDynamic2(int money, int[] coins, int[] table)
        {
            
            if (money == 0)
            {
                table[0] = 0;
                return table[0];
            }
            else if (table[money] != -1)
            {
                return table[money];
            }
            else 
            {
                for (int i = 1; i <= money; i++)
                {
                    var minFortheIteration = int.MaxValue;
                    foreach (var coin in coins)
                    {
                        if (i > coin)
                        {
                            var minWithThisCoin = 1 + MoneyChangeDynamic2(i - coin, coins, table);
                            if (minWithThisCoin < minFortheIteration)
                            {
                                minFortheIteration = minWithThisCoin;
                            }
                        }
                    }

                    table[i] = minFortheIteration;
                }

                return table[money];
            }

        }



    }
}
