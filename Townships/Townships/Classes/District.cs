using ProjectClassLib;
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
            initPlots();
        }

        public District(int width = 3, int height = 3)
        {
            plots = new DistrictPlotCell[height, width];
            initPlots();
        }

        void initPlots()
        {
            for (int i = 0; i < Plots.GetLength(0); i++)
            {
                for (int j = 0; j < Plots.GetLength(1); j++)
                {
                    Plots[i, j] = new DistrictPlotCell();
                }
            }
            ((VacantBuilding)Plots[Plots.GetLength(0) / 2, Plots.GetLength(1) / 2].LowerBuilding).Unlockable = true;
            ((VacantBuilding)Plots[Plots.GetLength(0) / 2, Plots.GetLength(1) / 2].UpperBuilding).Unlockable = true;
        }

        string name = "New District";
        DistrictPlotCell[,] plots = new DistrictPlotCell[2,2];

        public string Name { get => name; set => name = value; }
        public DistrictPlotCell[,] Plots { get => plots; set {
                plots = value;
                initPlots();
            } }

        public void UnlockNextPlot(bool surface)
        {
            Tools.ResetRandomSeed();
            int unlockedSur = 0;
            int unlockedUn = 0;
            foreach (var item in plots)
            {
                if (surface)
                {
                    if (item.UpperBuilding is VacantBuilding)
                    {
                        if (((VacantBuilding)item.UpperBuilding).Unlockable)
                        {
                            unlockedSur++;
                        }
                    }
                }
                else
                {
                    if (item.LowerBuilding is VacantBuilding)
                    {
                        if (((VacantBuilding)item.LowerBuilding).Unlockable)
                        {
                            unlockedUn++;
                        }
                    }
                }
            }
            if (surface)
            {
                if (unlockedSur < Plots.Length)
                {
                    bool ready = false;
                    while (!ready)
                    {
                        DistrictPlotCell plot = Plots[Tools.GetRandom(0, Plots.GetLength(0)), Tools.GetRandom(0, Plots.GetLength(1))];
                        if (plot.UpperBuilding is VacantBuilding)
                        {
                            if (!((VacantBuilding)plot.UpperBuilding).Unlockable)
                            {
                                ((VacantBuilding)plot.UpperBuilding).Unlockable = true;
                                ready = true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (unlockedUn < plots.Length)
                {
                    bool ready = false;
                    while (!ready)
                    {
                        DistrictPlotCell plot = Plots[Tools.GetRandom(0, Plots.GetLength(0)), Tools.GetRandom(0, Plots.GetLength(1))];
                        if (plot.LowerBuilding is VacantBuilding)
                        {
                            if (!((VacantBuilding)plot.LowerBuilding).Unlockable)
                            {
                                ((VacantBuilding)plot.LowerBuilding).Unlockable = true;
                                ready = true;
                            }
                        }
                    }
                }
            }
        }

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
