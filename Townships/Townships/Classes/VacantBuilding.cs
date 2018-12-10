using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class VacantBuilding:Building
    {
        public VacantBuilding()
        {
            Vacant = true;
            Name = "Vacant Plot";
        }

        double unlockCost = 0;
        bool unlocked = false;

        public double UnlockCost { get => unlockCost; set => unlockCost = value; }
        public bool Unlocked { get => unlocked; set => unlocked = value; }
    }
}
