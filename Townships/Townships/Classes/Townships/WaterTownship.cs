using ProjectClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class WaterTownship:Township
    {
        public WaterTownship()
        {
            ShipType = TownshipType.Water;
        }

        public static WaterTownship GetNewWaterTownship(int sizeModifier = 1)
        {
            WaterTownship ret = new WaterTownship();

            Tools.SetRandomSeed(4);

            for (int i = 0; i < Tools.GetRandom(3, 8 + sizeModifier); i++)
            {
                ret.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_1, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < Tools.GetRandom(5, 7 + sizeModifier); i++)
            {
                ret.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_2, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < Tools.GetRandom(2, 4 + sizeModifier); i++)
            {
                ret.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_3, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < Tools.GetRandom(1, 3 + sizeModifier); i++)
            {
                ret.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_4, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            
            return ret;
        }
    }
}
