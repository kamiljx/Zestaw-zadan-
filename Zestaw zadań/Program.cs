using System;

namespace Zestaw_zadań
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] tab = {23, 57, 54, 745, 1, 3, 74, 3};
            wlasciwosci(tab);
        }

        public static void wlasciwosci(int[] tab)
        {
            Console.WriteLine(GetMaxValue(tab));
        }

        public static int GetMaxValue(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length ; i++)
                if (max < tab[i])
                    max = tab[i];
            return max;
        }
    }
}