using System;

namespace ThreeCups
{
    class Program
    {
        // https://edabit.com/challenge/X3btpQQEBeezX4jhK
        // SOLVED

        static void Main(string[] args)
        {
            var cupA = new Cup('A', false);
            var cupB = new Cup('B', true);
            var cupC = new Cup('C', false);
            var cupFactory = new CupFactory(new string[] { "AB", "CA", "AB" }, cupA, cupB, cupC);
            cupFactory.EnumerateSwaps();
        }
    }
}
