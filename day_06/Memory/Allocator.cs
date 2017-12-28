using System;
using System.Linq;
using System.Collections.Generic;

namespace Memory
{
    public class Allocator
    {
        public int[] Next(int[] input)
        {
            var nextArray = (int[])input.Clone();
            var blockToSpread = IndexOfMax(input);
            var toSpread = input[blockToSpread];
            nextArray[blockToSpread] = 0;
            while (toSpread > 0)
            {
                blockToSpread++;
                nextArray[Wrap(blockToSpread, nextArray.Length)]++;
                toSpread--;
            }
            return nextArray;
        }

        public int RoundsToBalance(int[] input)
        {
            var states = new HashSet<string>();
            states.Add(ArrayString(input));
            var currentState = input;
            while (true)
            {
                currentState = Next(currentState);
                if (states.Contains(ArrayString(currentState)))
                {
                    return states.Count;
                }
                states.Add(ArrayString(currentState));
            }
        }

        public int RoundsInLoop(int[] input)
        {
            var states = new HashSet<string>();
            states.Add(ArrayString(input));
            var currentState = input;
            while (true)
            {
                currentState = Next(currentState);
                if (states.Contains(ArrayString(currentState)))
                {
                    return RoundsToBalance(currentState);
                }
                states.Add(ArrayString(currentState));
            }

        }

        private string ArrayString(int[] a)
        {
            return String.Join(",", new List<int>(a).Select(i => i.ToString()).ToArray());
        }

        private int IndexOfMax(int[] input)
        {
            var max = input.Max();
            return Array.IndexOf(input, max);
        }

        private int Wrap(int i, int length)
        {
            return i % length;
        }
    }
}
