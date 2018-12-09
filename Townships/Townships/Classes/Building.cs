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

        Guid uid = Guid.NewGuid();
        string name = "No Name Set";
        TownshipGridCell.TownCellSize buildingSize;

        public TownshipGridCell.TownCellSize BuildingSize { get => buildingSize; set => buildingSize = value; }
        public string Name { get => name; set => name = value; }
        public Guid Uid { get => uid; set => uid = value; }
    }
}
