using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes.Buildings
{
    public class FarmBuilding:Building
    {
        public FarmBuilding()
        {
            Thumb = @"C:\Users\Sven\source\repos\Saftfresse\Townships\Townships\Townships\Resources\farm_cow.png";
        }

        int animals = 5;

        public int Animals { get => animals; set => animals = value; }
    }
}
