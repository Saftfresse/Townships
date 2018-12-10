using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townships.Classes
{
    public class District
    {
        public District()
        {



            for (int i = 0; i < Plots.GetLength(0); i++)
            {
                for (int j = 0; j < Plots.GetLength(1); j++)
                {
                    Plots[i, j] = new DistrictPlotCell();
                }
            }

        }

        string name = "New District";
        DistrictPlotCell[,] plots = new DistrictPlotCell[5,5];

        public string Name { get => name; set => name = value; }
        public DistrictPlotCell[,] Plots { get => plots; set => plots = value; }

        public double GetTotalIncome()
        {
            double ret = 0;
            foreach (var item in Plots)
            {
                ret += item.GetTotalIncome();
            }
            return ret;
        }
    }
}
