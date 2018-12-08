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
        Bitmap screen;

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
            screen = new Bitmap(canvas.Width, canvas.Height);
            label1.Text = township.Name;
            label2.Text = township.ShipType.ToString() + " Type";
            draw();
        }
        
        void draw()
        {
            screen = new Bitmap(canvas.Width, canvas.Height);
            int size = 180, margin = 7, currX = margin, currY = margin, cX = canvas.Width / (size + margin), cY = township.Cells.Count / cX;
            





            using (var g = Graphics.FromImage(screen))
            {
                Console.WriteLine(cX + " - " + cY);
                foreach (var cell in township.Cells.OrderByDescending(x => x.CellTier))
                {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    Color c = new Color();
                    Image tier = Properties.Resources.tiers_0;
                    switch (cell.CellTier)
                    {
                        case TownshipGridCell.TownCellTier.Tier_1:
                            c = Color.FromArgb(23, 31, 102);
                            break;
                        case TownshipGridCell.TownCellTier.Tier_2:
                            tier = Properties.Resources.tiers_1;
                            c = Color.FromArgb(26, 59, 178);
                            break;
                        case TownshipGridCell.TownCellTier.Tier_3:
                            tier = Properties.Resources.tiers_2;
                            c = Color.FromArgb(19, 107, 196);
                            break;
                        case TownshipGridCell.TownCellTier.Tier_4:
                            tier = Properties.Resources.Tiers_3;
                            c = Color.FromArgb(0, 191, 255);
                            break;
                    }
                    cell.Bounds = new Rectangle(currX, currY, size, size);
                    g.DrawRectangle(new Pen(c, 1), cell.Bounds);
                    g.DrawString("PLOT", new Font("Roboto Lt", 18), new SolidBrush(ForeColor), currX , currY);
                    LinearGradientBrush lg = new LinearGradientBrush(new Point(0,0), new Point(size + margin, 0), Color.FromArgb(60,60,60), Color.FromArgb(19,19,19));
                    g.FillRectangle(lg, currX + 5, currY + 30, size - 10, 1);
                    g.DrawString("Size: " + cell.CellSize.ToString() + "\n" + "Tier: " + ((int)cell.CellTier + 1), Font, new SolidBrush(ForeColor), currX + margin, currY + 32);
                    g.DrawImage(tier, new Rectangle(currX + size - 60 - 3, currY + 5, 60, 20));




                    if (currX + (size + margin) > cX * (size + margin))
                    {
                        Console.WriteLine(currX + margin + size + " : " + cX * (size + margin));
                        currX = margin;
                        currY += margin + size;
                    }
                    else
                    {
                        currX += margin + size;
                    }
                }
                canvas.Height = currY;
            }
            canvas.Invalidate();
        }
        
        private void flow_cells_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lb = new LinearGradientBrush(new Point(label_hr_2.Width / 2, 0), new Point(0,0), Color.FromArgb(70, 70, 70), Color.FromArgb(19, 19, 19));
            LinearGradientBrush lb2 = new LinearGradientBrush(new Point(label_hr_2.Width / 2, 0), new Point(label_hr_2.Width, 0), Color.FromArgb(70, 70, 70), Color.FromArgb(19, 19, 19));
            e.Graphics.FillRectangle(lb, 0,0,label_hr_2.Width / 2, 1);
            e.Graphics.FillRectangle(lb2, label_hr_2.Width / 2, 0, label_hr_2.Width, 1);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(screen, 0, 0);
        }

        private void canvas_Resize(object sender, EventArgs e)
        {
            screen = new Bitmap(canvas.Width, canvas.Height);
            draw();
        }

        private void canvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TownshipGridCell cell = township.Cells.Find(x => x.Bounds.Contains(e.Location));
            if (cell != null && cell.CellTier < TownshipGridCell.TownCellTier.Tier_4)
            {
                cell.CellTier++;
            }
            draw();
            Console.WriteLine(township.Cells.Find(x => x.Bounds.Contains(e.Location))?.CellTier);
        }

        private void Form_ShipView_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = Width - label_hr_2.Width - 15;
            canvas.Width = flowLayoutPanel1.Width - 24;
            flowLayoutPanel1.Height = Height - 140;
            label3.Location = new Point(flowLayoutPanel1.Width - 9, label3.Location.Y);
            label_hr_2.Location = new Point(flowLayoutPanel1.Width - 9, label_hr_2.Location.Y);
            draw();
        }
    }
}
