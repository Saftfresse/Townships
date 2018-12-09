using ProjectClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class LandTownship:Township
    {
        public LandTownship()
        {
            ShipType = TownshipType.Land;
        }

        public static LandTownship GetNewLandTownship(int sizeModifier = 1)
        {
            LandTownship ret = new LandTownship();
            Tools.SetRandomSeed(4);

            for (int i = 0; i < Tools.GetRandom(0, sizeModifier); i++)
            {
                ret.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_1, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < Tools.GetRandom(0, (int)(sizeModifier * 0.7)); i++)
            {
                ret.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_2, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < Tools.GetRandom(0, (int)(sizeModifier * 0.4)); i++)
            {
                ret.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_3, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }
            for (int i = 0; i < Tools.GetRandom(0, (int)(sizeModifier * 0.2)); i++)
            {
                ret.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_4, CellSize = TownshipGridCell.TownCellSize.A1, Building = new Building() });
            }

            return ret;
        }
    }
}
