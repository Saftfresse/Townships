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
            building = new Building() { Name = "--" };
        }

        public enum TownCellTier
        {
            Tier_1,
            Tier_2,
            Tier_3,
            Tier_4
        }

        public enum CellDistrictSize
        {
            A,
            B,
            C,
            D,
            E,
            F,
            X
        }

        

        Rectangle bounds = new Rectangle();
        private TownCellTier cellTier;
        CellDistrictSize districtSize;
        Building building;
        District district = new District();

        public Building Building { get => building; set => building = value; }
        public TownCellTier CellTier { get => cellTier; set => cellTier = value; }
        public Rectangle Bounds { get => bounds; set => bounds = value; }
        public District District { get => district; set => district = value; }
        public CellDistrictSize DistrictSize { get => districtSize; set => districtSize = value; }
    }
}
