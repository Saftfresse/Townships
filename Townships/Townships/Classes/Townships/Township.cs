using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class Township
    {
        public Township()
        {
            for (int i = 0; i < 9; i++)
            {
                cells.Add(new TownshipGridCell());
            }
        }

        public enum TownshipType
        {
            Water,
            Land,
            Air,
            Space
        }


        string name = "";
        double costMaintainance = 0.0;
        double baseCost = 0.0;
        double speed = 1.0;

        Guid uid = Guid.NewGuid();
        TownshipType shipType;
        List<TownshipGridCell> cells = new List<TownshipGridCell>();

        public List<TownshipGridCell> Cells { get => cells; set => cells = value; }
        public TownshipType ShipType { get => shipType; set => shipType = value; }
        public string Name { get => name; set => name = value; }
        public Guid Uid { get => uid; set => uid = value; }
        public double CostMaintainance { get => costMaintainance; set => costMaintainance = value; }
        public double BaseCost { get => baseCost; set => baseCost = value; }
        public double Speed { get => speed; set => speed = value; }
    }
}
