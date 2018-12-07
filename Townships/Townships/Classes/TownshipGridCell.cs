using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class TownshipGridCell
    {
        public TownshipGridCell()
        {
            building = new Building() { BuildingSize = TownCellSize.A1, Name = "--" };
        }

        public enum TownCellTier
        {
            Tier_1,
            Tier_2,
            Tier_3,
            Tier_4
        }

        public enum TownCellSize
        {
            A1,
            A2,
            A3,
            B1,
            B2,
            C1,
            C2,
            D,
            X
        }

        Rectangle bounds = new Rectangle();
        private TownCellSize cellSize;
        private TownCellTier cellTier;
        Building building;

        public Building Building { get => building; set => building = value; }
        public TownCellSize CellSize { get => cellSize; set => cellSize = value; }
        public TownCellTier CellTier { get => cellTier; set => cellTier = value; }
        public Rectangle Bounds { get => bounds; set => bounds = value; }
    }
}
