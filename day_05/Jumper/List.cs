using System;

namespace Jumper
{
    public class List
    {
        public int[] Instructions { get; }
        public int Position { get; }

        public List(int[] instructions, int position)
        {
            this.Instructions = instructions;
            this.Position = position;
        }

        public List GetNext()
        {
            var newInstrucions = (int[])this.Instructions.Clone();
            newInstrucions[this.Position]++;
            return new List(newInstrucions, this.Position + this.Instructions[this.Position]);
        }

        public int GetMovesToJumpOut()
        {
            var sum = 0;
            var currentList = this;

            while (currentList.Position >= 0 && currentList.Position < currentList.Instructions.Length)
            {
                sum++;
                currentList = currentList.GetNext();
            }

            return sum;
        }
    }
}
