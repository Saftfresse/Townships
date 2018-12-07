using ProjectClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Townships.Classes;

namespace Townships
{
    public partial class Form_ShipView : Form
    {
        Township township;
        public Form_ShipView(Township ship)
        {
            township = ship;
            InitializeComponent();
        }

        private void label_hr_1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lb = new LinearGradientBrush(label_hr_1.ClientRectangle, Color.FromArgb(70,70,70), Color.FromArgb(19,19,19), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(lb, label_hr_1.ClientRectangle);
        }

        private void Form_ShipView_Load(object sender, EventArgs e)
        {
            label1.Text = township.Name;
            label2.Text = township.ShipType.ToString() + " Type";
            List<TownshipGridCell> cellsSort = township.Cells.OrderByDescending(x => x.CellTier).ToList();
            foreach (var item in cellsSort)
            {
                AddCell(item);
            }
        }

        void AddCell(TownshipGridCell cell)
        {
            Panel p = new Panel()
            {
                Parent = flow_cells,
                Size = new Size(180, 180),
                BorderStyle = BorderStyle.None,
                Padding = new Padding(2)
            };
            int index = township.Cells.IndexOf(cell);
            township.Cells[index].Bounds = p.ClientRectangle;
            switch (cell.CellSize)
            {
                case TownshipGridCell.TownCellSize.A1:
                    break;
                case TownshipGridCell.TownCellSize.A2:
                    break;
                case TownshipGridCell.TownCellSize.A3:
                    break;
                case TownshipGridCell.TownCellSize.B1:
                    break;
                case TownshipGridCell.TownCellSize.B2:
                    break;
                case TownshipGridCell.TownCellSize.C1:
                    break;
                case TownshipGridCell.TownCellSize.C2:
                    break;
                case TownshipGridCell.TownCellSize.D:
                    break;
                case TownshipGridCell.TownCellSize.X:
                    break;
            }

            Label l = new Label()
            {
                Parent = p,
                Location = new Point(2,2),
                Size = new Size(p.Width - 44, 40),
                TextAlign = ContentAlignment.TopCenter,
                Text = "Size: " + cell.CellSize.ToString() + "\n" + "Tier: " + ((int)cell.CellTier + 1)
            };
            PictureBox pb = new PictureBox()
            {
                Parent = p,
                Location = new Point(p.Width - 44,2),
                Size = new Size(40,20),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Color c = new Color();
            switch (cell.CellTier)
            {
                case TownshipGridCell.TownCellTier.Tier_1:
                    pb.Image = Properties.Resources.tiers_0;
                    c = Color.FromArgb(23, 31, 102);
                    break;
                case TownshipGridCell.TownCellTier.Tier_2:
                    pb.Image = Properties.Resources.tiers_1;
                    c = Color.FromArgb(26, 59, 178);
                    break;
                case TownshipGridCell.TownCellTier.Tier_3:
                    pb.Image = Properties.Resources.tiers_2;
                    c = Color.FromArgb(19, 107, 196);
                    break;
                case TownshipGridCell.TownCellTier.Tier_4:
                    pb.Image = Properties.Resources.Tiers_3;
                    c = Color.FromArgb(0, 191, 255);
                    break;
            }

            p.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(c, 2), p.ClientRectangle);
            };

            ExtendedPanel ep = new ExtendedPanel() {
                Parent = p,
                Size = p.Size,
                Opacity = 0
            };
            ep.BringToFront();
            ep.Click += (s, e) =>
            {
                Console.WriteLine(cell.CellTier);
            };

        }

        private void flow_cells_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
