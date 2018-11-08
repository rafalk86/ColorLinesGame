/* 
astar-1.0.cs may be freely distributed under the MIT license.

Copyright (c) 2013 Josh Baldwin https://github.com/jbaldwin/astar.cs

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without 
restriction, including without limitation the rights to use, 
copy, modify, merge, publish, distribute, sublicense, and/or sell 
copies of the Software, and to permit persons to whom the 
Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
OTHER DEALINGS IN THE SOFTWARE.
*/

using ColorLinesGame;
using System;
using System.Collections.Generic;

namespace AStarAlgorithm
{
	public class Grid2D
	{
		public GridNode[][] Grid;

        List<Tuple<int, int>> p = new List<Tuple<int, int>>();

        public int Width { get { return Grid.Length; } }
		public int Height { get { return Grid[0].Length; } }

		public GridNode Start;
		public GridNode Goal;

		public Grid2D(GridNode[][] grid, GridNode start, GridNode goal)
		{
			Grid = grid;
			Start = start;
			Goal = goal;
		}

		public Grid2D(int[,] matrix, int startX, int startY, int goalX, int goalY)
		{
			Start = new GridNode(this, startX, startY, false);
			Goal = new GridNode(this, goalX, goalY, false);

			Grid = new GridNode[Constants.NumBox()][];
			for (var i = 0; i < Constants.NumBox(); i++)
				Grid[i] = new GridNode[Constants.NumBox()];


			Grid[Start.X][Start.Y] = Start;
			Grid[Goal.X][Goal.Y] = Goal;

			for (var i = 0; i < Constants.NumBox(); i++)
			{
				for (var j = 0; j < Constants.NumBox(); j++)
				{
					// don't overwrite start/goal nodes
					if (Grid[i][j] != null)
						continue;

                    if (matrix[i, j] == 0)
                    {
                        Grid[i][j] = new GridNode(this, i, j, false);
                    }
                    else
                    {
                        Grid[i][j] = new GridNode(this, i, j, true);
                    }

                        
				}
			}
		}

        public List<Tuple<int, int>> Print(IEnumerable<INode> path)
        {
            p.Clear();
            for (var i = 0; i < Width; i++)
			{
				for (var j = 0; j < Height; j++)
				{
				    if(Grid[i][j].Print(Start, Goal, path) == ".")
                    {
                        p.Add(new Tuple<int, int>(i, j));
                    }
				}
			}
			return p;
		}
	}
}
