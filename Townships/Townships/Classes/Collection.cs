﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public static class Collection
    {
        public static List<Classes.Building> Buildings = new List<Classes.Building>() { new Factory() { BuildingSize = TownshipGridCell.TownCellSize.B1, Name = "New Factory" } };

        public static Classes.Building GetBuilding(Building _name)
        {
            Classes.Building returnBuild = Classes.Building.NoBuilding();
            if (((int)_name) < Buildings.Count)
            {
                returnBuild = Buildings[(int)_name];
            }
            return returnBuild;
        }

        public enum Building
        {
            Factory1
        }
    }
}
