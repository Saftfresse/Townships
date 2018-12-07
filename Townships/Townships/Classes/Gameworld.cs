using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class Gameworld
    {
        public Gameworld()
        {
            Random r = new Random(4);
            Township sh = new Township();
            for (int i = 0; i < r.Next(3,8); i++)
            {
                sh.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_1, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < r.Next(5,7); i++)
            {
                sh.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_2, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < r.Next(2,4); i++)
            {
                sh.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_3, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < r.Next(1,3); i++)
            {
                sh.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_4, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            sh.Name = "The Ultimus";
            sh.ShipType = Township.TownshipType.Land;
            ships.Add(sh);
        }

        List<Township> ships = new List<Township>();

        public List<Township> Ships { get => ships; set => ships = value; }
    }
}
