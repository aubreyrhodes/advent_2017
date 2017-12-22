using System;

namespace Jumper
{
    public class WeirdList
    {
        public int[] Instructions { get; }
        public int Position { get; }

        public WeirdList(int[] instructions, int position)
        {
            this.Instructions = instructions;
            this.Position = position;
        }

        public WeirdList GetNext()
        {
            var newInstrucions = (int[])this.Instructions.Clone();
            var offset = this.Instructions[this.Position];
            if (offset >= 3)
            {
                newInstrucions[this.Position]--;
            }
            else
            {
                newInstrucions[this.Position]++;
            }
            return new WeirdList(newInstrucions, this.Position + offset);
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
