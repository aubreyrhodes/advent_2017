using System;
using System.Collections.Generic;

namespace Spiral
{
    public class AdditiveSpiral
    {

        public int GetValueForBlock(int block)
        {
            var currentBlock = 1;
            var currentValue = 0;
            var currentBoard = new Dictionary<Tuple<int, int>, int>();
            var spiralService = new SpiralService();

            while (currentBlock <= block)
            {
                currentValue = 0;
                var currentPoint = spiralService.GetPosition(currentBlock);

                var x = currentPoint.X;
                var y = currentPoint.Y;


                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x - 1, y - 1), 0);
                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x, y - 1), 0);
                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x + 1, y - 1), 0);
                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x - 1, y), 0);
                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x, y), 0);
                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x + 1, y), 0);
                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x - 1, y + 1), 0);
                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x, y + 1), 0);
                currentValue += GetValueFromBoardWithDefault(currentBoard, Tuple.Create(x + 1, y + 1), 0);

                if (currentValue == 0)
                {
                    currentValue = 1;
                }

                currentBoard[Tuple.Create(x, y)] = currentValue;
                currentBlock++;
            }

            return currentValue;
        }

        private int GetValueFromBoardWithDefault(Dictionary<Tuple<int, int>, int> board, Tuple<int, int> key, int defaultValue)
        {
            try
            {
                return board[key];
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}