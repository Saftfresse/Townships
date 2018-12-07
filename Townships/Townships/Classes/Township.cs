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
            for (int i = 0; i < cells.Length; i++)
            {
                
            }
        }

        TownshipGridCell[,] cells = new TownshipGridCell[3,3];

        public TownshipGridCell[,] Cells { get => cells; set => cells = value; }
    }
}
