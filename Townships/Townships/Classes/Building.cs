using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class Building
    {
        public static Building NoBuilding()
        {
            return new Building();
        }

        public Building()
        {

        }

        public virtual void Update()
        {

        }

        bool vacant = true;
        double baseCost = 0;
        double baseIncome = 1;
        Guid uid = Guid.NewGuid();
        string name = "No Name Set";
        DistrictPlotCell.PlotCellSize buildingSize;
        List<BuildingLocation> requiredLocation = new List<BuildingLocation>();

        public enum BuildingLocation
        {
            Surface,
            Underground
        }

        public DistrictPlotCell.PlotCellSize BuildingSize { get => buildingSize; set => buildingSize = value; }
        public string Name { get => name; set => name = value; }
        public Guid Uid { get => uid; set => uid = value; }
        public bool Vacant { get => vacant; set => vacant = value; }
        public double BaseCost { get => baseCost; set => baseCost = value; }
        public double BaseIncome { get => baseIncome; set => baseIncome = value; }
        public List<BuildingLocation> RequiredLocation { get => requiredLocation; set => requiredLocation = value; }
    }
}
