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
            LandTownship sh = new LandTownship();
            for (int i = 0; i < r.Next(3,8); i++)
            {
                sh.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_1, DistrictSize = TownshipGridCell.CellDistrictSize.A, Building = new Building() });
            }
            for (int i = 0; i < r.Next(5,7); i++)
            {
                sh.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_2, DistrictSize = TownshipGridCell.CellDistrictSize.B, Building = new Building() });
            }
            for (int i = 0; i < r.Next(2,4); i++)
            {
                sh.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_3, DistrictSize = TownshipGridCell.CellDistrictSize.C, Building = new Building() });
            }
            for (int i = 0; i < r.Next(1,3); i++)
            {
                sh.Cells.Add(new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_4, DistrictSize = TownshipGridCell.CellDistrictSize.D, Building = new Building() });
            }
            sh.Name = "The Ultimus";
            ships.Add(sh);
            LandTownship sh2 = new LandTownship();
            sh2.Cells.Clear();
            sh2.Cells.AddRange(new TownshipGridCell[] {
                        new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_1, Building = new Building() },
                        new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_1, Building = new Building() },
                        new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_1, Building = new Building() },
                        new TownshipGridCell() { CellTier = TownshipGridCell.TownCellTier.Tier_2, Building = new Building() }});
            sh2.Name = "New Dawn";
            ships.Add(sh2);
            LandTownship sh3 = LandTownship.GetNewLandTownship();
            sh3.Name = "Berserk";
            ships.Add(sh3);
        }

        List<Township> ships = new List<Township>();

        public List<Township> Ships { get => ships; set => ships = value; }
    }
}
