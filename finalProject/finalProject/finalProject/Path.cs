using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    public class Path
    {
        public List<Vector2> path = new List<Vector2>();
        
        public bool findpath(int[,] m, Vector2 start, Vector2 end)
        {
            int[,] distance = new int[m.GetLength(0), m.GetLength(1)];
            int[,] visited = new int[m.GetLength(0), m.GetLength(1)];
            Vector2[,] previous = new Vector2[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < distance.GetLength(0); ++i)
            {
                for (int j = 0; j < distance.GetLength(1); ++j)
                {
                    distance[i, j] = 1000000;
                    visited[i, j] = 0;
                    previous[i, j] = Vector2.Zero;
                }
            }
            int x = (int)start.X, y = (int)start.Y;
            distance[x, y] = 0;
            visited[x, y] = 1;
            while (distance[x, y] != 1000000 || visited[(int)end.X, (int)end.Y] != 1)
            {
                if (m[x + 1, y] == 1 && distance[x, y] + 1 < distance[x + 1, y])
                {
                    distance[x + 1, y] = distance[x, y] + 1;
                    previous[x + 1, y] = new Vector2(x, y);
                }
                if (m[x, y + 1] == 1 && distance[x, y] + 1 < distance[x, y + 1])
                {
                    distance[x, y + 1] = distance[x, y] + 1;
                    previous[x, y + 1] = new Vector2(x, y);
                }
                if (m[x - 1, y] == 1 && distance[x, y] + 1 < distance[x - 1, y])
                {
                    distance[x - 1, y] = distance[x, y] + 1;
                    previous[x - 1, y] = new Vector2(x, y);
                }
                if (m[x, y - 1] == 1 && distance[x, y] + 1 < distance[x, y - 1])
                {
                    distance[x, y - 1] = distance[x, y] + 1;
                    previous[x, y - 1] = new Vector2(x, y);
                }
                visited[x, y] = 1;
                findMinIndex(distance,ref x, ref y);

            }
            if (visited[(int)end.X, (int)end.Y] != 1)
                return false;
            else
            {
                x = (int)end.X;
                y = (int)end.Y;
                List<Vector2> p= new List<Vector2>();
                p.Add(end);
                while (x != (int)start.X || y != (int)start.Y)
                {
                    Vector2 temp = previous[x, y];
                    p.Add(temp);
                    x = (int)temp.X;
                    y = (int)temp.Y;
                }
                p.Add(start);
                p.Reverse();
                return true;
            }
        }

        private void findMinIndex(int[,] a, ref int x, ref int y)
        {
            x = 0; y = 0;
            int min = a[0, 0];
            for(int i = 0;i<a.GetLength(0);++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
        }
    }
}
