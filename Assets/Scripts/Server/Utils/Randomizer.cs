using System;

namespace Server.Utils
{
    public static class Randomizer
    {
        private static readonly int _defaultMinValue = 0;
        private static readonly Random _random = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public static int GetRandomNumber(int max)
        {
            return _random.Next(_defaultMinValue, max);
        }
    }
}