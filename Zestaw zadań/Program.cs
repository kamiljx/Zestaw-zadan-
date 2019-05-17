using System;
using System.Runtime.Remoting;

namespace Zestaw_zadań
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int[] tab = {23, 57, 54, 745,  3, 74, 3, 99, 101};
            wlasciwosci(tab);
        }

        public static void wlasciwosci(int[] tab)
        {
            Console.WriteLine(GetMaxValue(tab));
            Console.WriteLine(GetMinValue(tab));
            Console.WriteLine(MaxParityIndex(tab));
        }

        private static int GetMaxValue(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length ; i++)
                if (max < tab[i])
                    max = tab[i];
            return max;
        }

        public static int GetMinValue(int[] tab)
        {
            int min = tab[0];
            for (int i = 0; i < tab.Length; i++)
                if (min > tab[i])
                    min = tab[i];
            return min;
        }

        public static int MaxParityIndex(int[] tab)
        {
            int maxParity = tab[0];
            for (int i = 2; i < tab.Length; i+= 2)
                if (maxParity < tab[i])
                    maxParity = tab[i];
            return maxParity;

        }
        
    }
}