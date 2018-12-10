using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class DistrictPlotCell
    {
        public DistrictPlotCell()
        {
            UpperBuilding = new VacantBuilding() { RequiredLocation = new List<Building.BuildingLocation>() { Building.BuildingLocation.Surface }, Name = "Surface Plot" };
            LowerBuilding = new VacantBuilding() { RequiredLocation = new List<Building.BuildingLocation>() { Building.BuildingLocation.Underground }, Name = "Underground Plot" };
        }

        Building upperBuilding;
        Building lowerBuilding;

        public enum PlotCellSize
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

        PlotCellSize plotSize;
        Rectangle bounds = new Rectangle();

        public PlotCellSize PlotSize { get => plotSize; set => plotSize = value; }
        public Building UpperBuilding { get => upperBuilding; set => upperBuilding = value; }
        public Building LowerBuilding { get => lowerBuilding; set => lowerBuilding = value; }
        public Rectangle Bounds { get => bounds; set => bounds = value; }

        public double GetTotalIncome()
        {
            return UpperBuilding.BaseIncome + LowerBuilding.BaseIncome;
        }

    }
}
