using System;

namespace Spiral
{
    public class SpiralService
    {
        public Point GetPosition(int cell)
        {
            var x = 1;
            var y = 0;
            var current_cell = 2;
            var directions = new Tuple<int, int>[] { Tuple.Create(0, 1), Tuple.Create(-1, 0), Tuple.Create(0, -1), Tuple.Create(1, 0) };
            var current_direction = 0;
            var current_side_half = 1;
            var current_radius = 1;
            var just_turned = false;

            while (current_cell < cell)
            {
                // walk to the cell
                x += directions[current_direction].Item1;
                y += directions[current_direction].Item2;
                current_cell++;

                if (y == (-1 * current_radius) && x == current_radius && !just_turned)
                {
                    current_radius++;
                    current_side_half++;
                    just_turned = true;
                }
                else
                {
                    just_turned = false;
                }

                // turn at the corners
                if (Math.Abs(x) == current_side_half && Math.Abs(y) == current_side_half)
                {
                    current_direction++;
                }

                if (x == current_side_half && y == ((-1 * current_side_half) + 1))
                {
                    current_direction++;
                }

                if (current_direction == 4)
                {
                    current_direction = 0;
                }
            }

            return new Point(x, y);
        }
    }
}
