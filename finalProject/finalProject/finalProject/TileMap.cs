using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finalProject
{
    class MapRow
    {
        public List<MapCell> Columns = new List<MapCell>();
    }

    class TileMap
    {
        public List<MapRow> Rows = new List<MapRow>();
        public int MapWidth = 50;
        public int MapHeight = 50;

        public TileMap()
        {
            for (int y = 0; y < MapHeight; y++)
            {
                MapRow thisRow = new MapRow();
                for (int x = 0; x < MapWidth; x++)
                {
                    thisRow.Columns.Add(new MapCell(0));
                }
                Rows.Add(thisRow);
            }

            // Create Sample Map Data

//for (int i = 3; i < 13; i++)
//{
//    for (int j = 2; j < 21; j++)
//    {
//        Rows[i].Columns[j].TileID = 1;
//    }
//}

            // End Create Sample Map Data
        }
    }
}
